using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace AOGL
{
    public partial class EngravingForm : Form
    {

        private string fileName;

        public EngravingForm(string __fileName, List<string> __gcode)
        {
            /*
             * WarningForm tak jak jest w projekcie
             */
            WarningForm warningForm = new WarningForm()
            {
                MinimizeBox = false,
                MaximizeBox = false,
            };
            warningForm.ShowDialog();
            if (!warningForm.OK)
            {
                this.Close();
            } 
            else
            {
                InitializeComponent();
                fileName = __fileName;
                originalInstructions = __gcode;

                try
                {
                    //Proboj nawiazac polaczenie z urzadzeniem
                    PortFinder pf = new PortFinder();
                    if(pf.Status == PortFinder.PortFinderStatus.PortFound)
                    {
                        SetSerialPort(pf.PortNameFound);
                        OpenSerialPort();
                    } 
                    else
                    {
                        DialogResult portFinderErrorDialog = MessageBox.Show("Wystapil blad podczas wykrywania urzadzenia.",
                            "Nie wykryto urzadzenia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                           );
                    }

                    // Wszystkie instrukcje
                    queuedInstructions = new Queue<string>();
                    // Nastepne instrukcje
                    nextInstructions = new Queue<string>();
                    // Przygotuj progress bar
                    progressBar.Maximum = originalInstructions.Count;
                    // Przygotuj labelTitle
                    labelTitle.Text = $"Grawerowanie {Path.GetFileName(fileName)}...";
                    // Przenies instrukcje z argumentow konstruktora EngravingForm do queuedInstructions
                    foreach (string line in originalInstructions)
                    {
                        queuedInstructions.Enqueue(line);
                    }

                    // Inicjalizacja Listy<int> instructionTimes
                    instructionTimes = new List<int>();
                    // Zacznij mierzyc czas
                    stopwatch = Stopwatch.StartNew();
                    // Rozpocznij dodawanie instrukcji
                    PopulateNextInstructions(1);
                    // Aktywuj proces
                    ActivateInstructionTimer();
                    ActivateSecondsTimer();
                }
                catch
                {
                    DialogResult portFinderErrorDialog = MessageBox.Show("Wystapil blad podczas grawerowania.",
                            "Blad",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                           );
                }
            }
        }

        #region Timer&Instuctions
        /* 
         * Funkcje zwiazane z czasowa obsluga instrukcji
         */
        private static System.Timers.Timer instructionTimer;

        // Zmienne kontrolne
        private bool responseReceived = true;
        private bool instuctionHold = false;
        /*
         *  Funkcje i zmienne zwiazane z instrukcjami GCode
         */
        private List<string> originalInstructions;
        private Queue<string> queuedInstructions;
        private Queue<string> nextInstructions;
        private delegate void InstructionDelegate();

        // Przy mniej niz 20 instrukcjach zapowiedz kolejne instrukcje
        private const int instructionsLimitToPopulate = 20;
        private const int instructionBatchSize = 100;

        /*
         *  Obliczanie czasu
         */
        private System.Timers.Timer secondsTimer;
        private delegate void SecondsTimerDelegate();
        private Stopwatch stopwatch;
        private List<int> instructionTimes;
        private TimeSpan estimatedTime;

        /*
         *  private delegate void InstructionDelegate();
         */
        private delegate void CloseDelegate();

        private void ActivateSecondsTimer()
        {
            secondsTimer = new System.Timers.Timer(1000);
            secondsTimer.Elapsed += SecondsTimerActon;
            secondsTimer.AutoReset = true;
            secondsTimer.Enabled = true;
        }

        private void SecondsTimerActon(object sender, ElapsedEventArgs e)
        {
            this.BeginInvoke(new SecondsTimerDelegate(UpdateTimeInformation), new object[] { });
        }

        private void UpdateTimeInformation()
        {
            // Sredni czas
            var averageInstructionTime = instructionTimes.Average();
            var totalInstructionTime = averageInstructionTime * originalInstructions.Count;
            var __estimatedTime = totalInstructionTime - (averageInstructionTime * (double)progressBar.Value);
            estimatedTime = TimeSpan.FromMilliseconds(__estimatedTime);
            

            // Wyswietl pozostaly czas
            labelTime.Text = $"{String.Format("Pozostaly czas: {0} minut {1} sekund", estimatedTime.Minutes, estimatedTime.Seconds)}";
        }

        private void ActivateInstructionTimer()
        {
            // Tick timera co 25ms
            instructionTimer = new System.Timers.Timer(25);
            // Funkcja wywolywana co 25ms przez timer
            instructionTimer.Elapsed += InstructionTimerAction;
            instructionTimer.AutoReset = true;
            instructionTimer.Enabled = true;
        }

        private void InstructionTimerAction(Object source, ElapsedEventArgs e)
        {
            // Funkcja wywolywana przez timer co 25s!
            if ((responseReceived && nextInstructions.Count > 0) && !instuctionHold)
            {
                /*
                 *  Jesli:
                 *  - odebrana wiadomosc zwrotna od urzadzenia o gotowosci przyjecia kolejnej instrukcji
                 *  - instrukcje znajduja sie kolejce zapowiedzianych instrukcji (nextInstructions)
                 *  - proces nie jest wstrzymany
                 */
                // Wyslij do urzadzenia kolejna instrukcje
                serialPort.WriteLine(nextInstructions.Dequeue());
                // Timer nie ma dostepu do komponentow UI, wiec musimy uzyc delegata ktory bedzie to za nas robil.
                this.BeginInvoke(new InstructionDelegate(InstructionIndicatorUpdate), new object[] { });
                // Czekaj na odpowiedz urzadzenia
                responseReceived = false;
            } 
            else if (nextInstructions.Count == 0 && queuedInstructions.Count == 0)
            {
                secondsTimer.Stop();
                instructionTimer.Stop();

                DialogResult processEnded = MessageBox.Show(
                        "Zakonczono.",
                        $"Grawerowanie {fileName}",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                    );

                this.BeginInvoke(new CloseDelegate(EndAction), new object[] { });
            }
        }

        private void EndAction()
        {
            HoldProcess();
            CloseSerialPort();
            this.Close();
        }

        private void InstructionIndicatorUpdate()
        {
            /*
             *  Przy wyslanej instrukcji:
             */
            // Stopuj czasomierz! Dodaj czas wykoniania do listy, obliczaj sredni czas wykoniania instrukcji
            instructionTimes.Add((int)stopwatch.ElapsedMilliseconds);
            stopwatch.Stop();

            // Kasuj gorna instrukcje w liscie listBoxTerminal
            listBoxTerminal.Items.RemoveAt(0);

            // Dodaj punkt do paska postepu
            progressBar.Value += 1;

            // Wyswietl ilosc wykonanych instrukcji / pozostalych instrukcji
            labelInstructions.Text = $"Instrukcji: {progressBar.Value}/{originalInstructions.Count}";

            // Wyswietl wartosc procentowa ukonczenia procesu grawerowania
            double procent = ((double)progressBar.Value / (double)progressBar.Maximum) * 100.0;
            labelProcent.Text = $"Wykonano {String.Format("{0:0.##}", procent)}%";
            this.Text = $"Grawerowanie {String.Format("{0:0.##}", procent)}%";

            // Zapowiadaj kolejne instrukcje jesli ilosc mniejsza niz limit
            if (listBoxTerminal.Items.Count < instructionsLimitToPopulate)
            {
                if (queuedInstructions.Count >= instructionBatchSize)
                {
                    PopulateNextInstructions(instructionBatchSize);
                }
                else
                {
                    // Ostatnia seria instrukcji
                    PopulateNextInstructions(queuedInstructions.Count);
                }
            }

            // Uruchom czasomierz od nowa!
            stopwatch.Reset();
            stopwatch.Start();
        }
        private void PopulateNextInstructions(int ammount)
        {
            if (ammount == 0)
            {
                serialPort.Write("M05 S0");
                listBoxTerminal.Items.Add("M05 S0");
            }
            else
            {
                for (int i = 0; i < ammount; i++)
                {
                    string passing = queuedInstructions.Dequeue();
                    listBoxTerminal.Items.Add(passing);
                    nextInstructions.Enqueue(passing);
                }
            }

        }
        #endregion


        #region SerialPort
        /*
         *  SerialPort
         */
        private SerialPort serialPort;
        private delegate void ResponseDelegate(string data);

        private void SetSerialPort(string portName)
        {
            /*
             * Tutaj tworzymy nowy obiekt serial port
             * Za kazdym razem kiedy wcisniemy przycisk Polacz
             */
            try
            {
                serialPort = new SerialPort(
                    portName,
                    115200,
                    Parity.None,
                    8,
                    StopBits.One
                );
                serialPort.Handshake
                    = Handshake.None;
                serialPort.ReadTimeout
                    = 500;
                serialPort.WriteTimeout
                    = 500;
                serialPort.DataReceived
                    += new SerialDataReceivedEventHandler(SerialPortDataReceived);
            }
            catch (Exception ex)
            {
                // Wyrzuc blad jesli nie powodzenie
                MessageBox.Show(
                        $"Creating new SerialPort object failed: {ex.Message}",
                        "SerialPort Exception",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
            }
        }
        
        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Mechanizm czytania przychodzacych danych od urzadzenia
            Thread.Sleep(25);
            string data = serialPort.ReadLine();
            // Delegat odbierajacy dane z poza GUI, wysylajace dane do GUI. Inaczej sie nie da
            this.BeginInvoke(new ResponseDelegate(ResponseReceived), new object[] { data });
        }

        private void ResponseReceived(string data)
        {
            responseReceived = true;
        }

        private void OpenSerialPort()
        {
            // Funkcja otwierajaca nowe polaczenie z urzadzeniem
            try
            {
                // Otworz jesli nie otwarte
                if (!(serialPort.IsOpen))
                {
                    serialPort.Open();
                }
            }
            catch (Exception ex)
            {
                // Wyrzuc blad jesli nie powodzenie
                MessageBox.Show(
                    $"Opening SerialPort failed: {ex.Message}",
                    "openSerialPort Exception",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void CloseSerialPort()
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            }
            catch (Exception ex)
            {
                // Wyrzuc blad jesli nie powodzenie
                MessageBox.Show(
                    $"Closing SerialPort failed: {ex.Message}",
                    "closeSerialPort Exception",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
        #endregion


        #region Endgame

        private void HoldProcess()
        {
            instuctionHold = true;
            progressBar.Enabled = false;
            progressBar.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!instuctionHold)
            {
                HoldProcess();
            } 
            else
            {
                instuctionHold = false;
                progressBar.Enabled = true;
                progressBar.Visible = true;
            }
        }

        private void EngravingForm_Leave(object sender, EventArgs e)
        {
            HoldProcess();
            CloseSerialPort();
            this.Close();
        }

        private void EngravingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HoldProcess();
            CloseSerialPort();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HoldProcess();
            CloseSerialPort();
            this.Close();
        }

        #endregion
    }
}
