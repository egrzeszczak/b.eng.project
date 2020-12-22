using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace AOGL
{
    public partial class MainForm : Form
    {
        public WelcomeForm welcomeForm;

        public MainForm()
        {
            InitializeComponent();
        }

        #region SideMenu

        //================================================================================================================================================ Side Menu

        /*  Funkcje obsługi bocznego panelu menu
         *
         *
         *
         */

        private void sidePanelCollapse()
        {
            // Schowaj panel
            panelSideMenu.Width = 64;
            menuFile.Text = "";
            menuSettings.Text = "";
            menuLaser.Text = "";
            menuLeave.Text = "";
        }

        private void sidePanelExtend()
        {
            // Wysuń panel
            panelSideMenu.Width = 300;
            menuFile.Text = "Plik";
            menuSettings.Text = "Opcje";
            menuLaser.Text = "Laser";
            menuLeave.Text = "Wyjdź";
        }

        private void sidePanelHide()
        {
            sidePanelCollapse();
            sidePanelHideAll();
        }

        private void sidePanelHideAll()
        {
            // Schowaj wszystkie podopcje
            panelFile.Visible = false;
            panelSettings.Visible = false;
            panelLaser.Visible = false;
        }

        private void sidePanelHideSubMenu()
        {
            // Select dla wybranej opcji
            if (panelFile.Visible)
            {
                panelFile.Visible = false;
            }
            if (panelSettings.Visible)
            {
                panelSettings.Visible = false;
            }
            if (panelLaser.Visible)
            {
                panelLaser.Visible = false;
            }
        }

        private void sidePanelShowSubMenu(Panel subMenu)
        {
            // Zmiana podopcji
            if (!subMenu.Visible)
            {
                // Pokaż klikniętą kategorię
                sidePanelHideAll();
                sidePanelExtend();
                subMenu.Visible = true;
            }
            else
            {
                // Ponowne kliknięcie na rozwinięte menu chowa menu
                sidePanelCollapse();
                subMenu.Visible = false;
            }
        }

        //================================================================================================================================================ Side Menu

        #endregion SideMenu

        #region DriverManager

        //================================================================================================================================================ Driver Manager

        /*
         * Funkcje odpowiedzialne za wychwytywanie sterownika z systemu
         * i instalowanie sterownika w przypadku jego braku
         */

        // Zmienna globalna czy sterownik zainstalowany?
        public bool __isDriverInstalled = false;

        private void checkDriverInstalled()
        {
            // Sprawdź obecność sterownikia
            Debug.WriteLine("driverManagerRoutine():");

            DriverManager driverManager = new DriverManager();
            DriverManager.DriverStatus driverStatus = driverManager.Status;

            // Czy sterownik zainstalowany
            if (driverStatus == DriverManager.DriverStatus.DriverNotFound)
            {
                // Sterownika nie znaleziono. Przekaż złą wiadomość użytkownikowi
                Debug.WriteLine("\t-> DriverStatus: " + driverStatus);
                __isDriverInstalled = false;
                DialogResult installDriverDialog = MessageBox.Show("Sterownik potrzebny do działania lasera nie jest zainstalowany. Zainstalować go teraz?",
                                "Nie odnaleziono sterownika",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information
                               );

                // Podświetl przycisk do instalacji sterownika
                goDriver.Enabled = true;
                // Czy użytkownik chce w ogóle zainstalować sterownik? Hm?
                if (installDriverDialog == DialogResult.Yes)
                {
                    // Wywołaj .exe z instalatorem sterownika
                    Debug.WriteLine("Użytkownik chce zainstalować sterownik");
                    runDriverInstalation();
                    checkDriverInstalled();
                }
                else
                {
                    // Użytkownik nie chce zainstalować sterownika
                    Debug.WriteLine("Użytkownik nie chce zainstalować sterownika");
                }
            }
            else
            {
                // Sterownik znaleziony
                Debug.WriteLine("\t-> DriverStatus: " + driverStatus);
                __isDriverInstalled = true;
                goDriver.Enabled = false;
                goDriver.Text = "Sterownik zainstalowany";
            }
        }

        private void runDriverInstalation()
        {
            // INSTALACJA STEROWNIKA
        }

        //================================================================================================================================================ Driver Manager

        #endregion DriverManager

        #region StatusBar

        //================================================================================================================================================ Status/Footer

        /*
         * Funkcje odpowiedzialne za wyświetlanie statusu w dolnym panelu
         */

        public enum StatusBoxStatus
        {
            Connected,          // Polaczono
            Disconnected,       // Rozlaczono
            ConnectionError,    // Blad przy polaczeniu
            Busy                // Laser pracuje
        }

        private void setStatusBarMessage(string message)
        {
            textStatus.Text = message;
        }

        private void setStatusBoxStatus(StatusBoxStatus status, string portName)
        {
            switch (status)
            {
                case StatusBoxStatus.Connected:
                    {
                        textStatusBox.Text = "✔" + portName;
                        textStatusBox.BackColor = Color.FromArgb(143, 255, 104);
                        panelStatusBoxPadding.BackColor = Color.FromArgb(143, 255, 104);
                        textStatusBox.ForeColor = Color.Black;
                        break;
                    }
                case StatusBoxStatus.Disconnected:
                    {
                        textStatusBox.Text = "✘";
                        textStatusBox.BackColor = Color.FromArgb(73, 79, 90);
                        panelStatusBoxPadding.BackColor = Color.FromArgb(73, 79, 90);
                        textStatusBox.ForeColor = SystemColors.ControlDarkDark;
                        break;
                    }
                case StatusBoxStatus.ConnectionError:
                    {
                        textStatusBox.Text = "✘ERROR";
                        textStatusBox.BackColor = Color.FromArgb(234, 86, 72);
                        panelStatusBoxPadding.BackColor = Color.FromArgb(234, 86, 72);
                        textStatusBox.ForeColor = Color.White;
                        break;
                    }
                case StatusBoxStatus.Busy:
                    {
                        textStatusBox.Text = "✔" + portName;
                        textStatusBox.BackColor = Color.Orange;
                        panelStatusBoxPadding.BackColor = Color.Orange;
                        textStatusBox.ForeColor = Color.White;
                        break;
                    }
            }
        }

        //================================================================================================================================================ Status/Footer

        #endregion StatusBar

        #region Buttons

        //================================================================================================================================================ Przyciski

        private void buttonDOWN_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(__sliderStepValue.ToString(), __sliderFeedrateValue.ToString());
            controlPanelMoveAction("G0 X0 Y-{0} F{1}");
        }

        private void buttonDOWNLEFT_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(__sliderStepValue.ToString(), __sliderFeedrateValue.ToString());
            controlPanelMoveAction("G0 X-{0} Y-{0} F{1}");
        }

        private void buttonDOWNRIGHT_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(__sliderStepValue.ToString(), __sliderFeedrateValue.ToString());
            controlPanelMoveAction("G0 X{0} Y-{0} F{1}");
        }

        private void buttonHOME_Click(object sender, EventArgs e)
        {
            sendCommand(String.Format("G01 X0 Y0 F{0}", __sliderFeedrateValue));
        }

        private void buttonLaserOff_Click(object sender, EventArgs e)
        {
            controlPanelLaserOff();
        }

        private void buttonLaserOn_Click(object sender, EventArgs e)
        {
            controlPanelLaserOn();
        }

        private void buttonLEFT_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(__sliderStepValue.ToString(), __sliderFeedrateValue.ToString());
            controlPanelMoveAction("G0 X-{0} Y0 F{1}");
        }

        private void buttonRIGHT_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(__sliderStepValue.ToString(), __sliderFeedrateValue.ToString());
            controlPanelMoveAction("G0 X{0} Y0 F{1}");
        }

        private void buttonUP_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(__sliderStepValue.ToString(), __sliderFeedrateValue.ToString());
            controlPanelMoveAction("G0 X0 Y{0} F{1}");
        }

        private void buttonUPLEFT_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(__sliderStepValue.ToString(), __sliderFeedrateValue.ToString());
            controlPanelMoveAction("G0 X-{0} Y{0} F{1}");
        }

        private void buttonUPRIGHT_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(__sliderStepValue.ToString(), __sliderFeedrateValue.ToString());
            controlPanelMoveAction("G0 X{0} Y{0} F{1}");
        }

        private void goConnect_Click(object sender, EventArgs e)
        {
            tryConnect();
        }

        private void goDriver_Click(object sender, EventArgs e)
        {
            runDriverInstalation();
            sidePanelHide();
        }

        private void goExport_Click(object sender, EventArgs e)
        {
            // Zapisz plik z instrukcjami
        }

        private void goLeave_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Wyjdź z aplikacji
        }

        public void addFileToWelcome(string path)
        {
            ListViewItem listViewItem = new ListViewItem(
                    new string[] {
                        Path.GetFileNameWithoutExtension(path),
                        path
                    }
                );
            welcomeForm.listViewLatest.Items.Add(listViewItem);

            List<string> paths = new List<string>();
            foreach (ListViewItem element in welcomeForm.listViewLatest.Items)
            {
                paths.Add(element.SubItems[1].Text);
            }
            paths = paths.Distinct().ToList();

            StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\last.aogl", false);
            foreach (string line in paths)
            {
                sw.WriteLine(line);
            }
            sw.Close();
        }

        public void loadFilesToWelcome()
        {
            StreamReader sr = new StreamReader(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\last.aogl"
                );

            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                welcomeForm.listViewLatest.Items.Add(
                    new ListViewItem(
                            new string[]
                            {
                                Path.GetFileNameWithoutExtension(line),
                                line
                            }
                        )
                    );
            }
        }

        public void goLoadFile_Click(object sender, EventArgs e)
        {
            // Ładowanie pliku .svg, .jpg, .png
            OpenFileDialog openFile = new OpenFileDialog();
            //Filtry dla OPF
            openFile.Filter = "Obrazy JPG (.jpg)|*.jpg|Obrazy PNG (.png)|*.png|Obrazy wektorowe (.svg)|*.svg|All files (*.*)|*.*";
            //Pokazuj najpierw obrazy JPG
            openFile.FilterIndex = 1;

            //Czy wczytany jakis obraz?
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                addFileToWelcome(openFile.FileName);

                //Wybrano jakis obraz
                Debug.WriteLine("Obraz wybrany");
                //Nowa zakladka
                TabPage loadFileTab = new TabPage(Path.GetFileNameWithoutExtension(openFile.FileName) + $" (Obraz {Path.GetExtension(openFile.FileName)})");
                //Ustawienia dla CanvasForm
                CanvasForm canvasForm = new CanvasForm(serialPort, openFile.FileName, tabControl)
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                };
                //Dodaj do nowej zakladki canvasForm
                loadFileTab.Controls.Add(canvasForm);
                //Dodaj nowa zakladke do TabControl
                tabControl.Controls.Add(loadFileTab);
                //Wybierz ta zakladke
                tabControl.SelectedTab = loadFileTab;
                //Pokaz
                canvasForm.Show();
            }
            else { }

            sidePanelHideAll();
            sidePanelCollapse();
        }

        public void goLoadGCode_Click(object sender, EventArgs e)
        {
            // Ładowanie pliku .nc, .gcode, .txt
            OpenFileDialog openFile = new OpenFileDialog();
            //Filtry dla OPF
            openFile.Filter = "Instrukcje GCode|*.nc|Instrukcje GCode|*.gcode|Pliki tekstowe (.txt)|*.txt|All files (*.*)|*.*";
            //Pokazuj najpierw instrukcje .nc
            openFile.FilterIndex = 1;

            //Czy wczytana jakas instrukcja?
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                addFileToWelcome(openFile.FileName);

                TabPage loadGcodeTab = new TabPage(Path.GetFileNameWithoutExtension(openFile.FileName) + " (GCode)");

                GCodeForm codeForm = new GCodeForm(serialPort, tabControl, openFile.FileName)
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };
                //Dodaj do nowej zakladki canvasForm
                loadGcodeTab.Controls.Add(codeForm);
                //Dodaj nowa zakladke do TabControl
                tabControl.Controls.Add(loadGcodeTab);
                //Wybierz ta zakladke
                tabControl.SelectedTab = loadGcodeTab;
                //Pokaz
                codeForm.Show();
            }
            else { }

            sidePanelHideAll();
            sidePanelCollapse();
        }

        public void goTest_Click(object sender, EventArgs e)
        {
            sidePanelHide();
            // Otworz okno z scenariuszami testowymi
            TestForm testForm = new TestForm();
            // Otworz jako okno dialogowe (blokuj interakcje z tlem)
            testForm.ShowDialog();

            // Jesli wybrano jakis element
            if (testForm.objectReference is null)
            {
                // Wcisnieto przycisk Close w TestForm
                Debug.WriteLine("Nie wybrano nic.");
            }
            else
            {
                // Wybrano jakis obiekt
                Object objectSelected = testForm.objectReference;
                string objectName = testForm.objectName;
                Debug.WriteLine($"Wybrano {objectName}, {objectSelected.ToString()}!");

                // Okresl typ obiektu wybranego
                if (objectSelected is System.Byte[])
                {
                    // Obiekt to System.Byte[] czyli lancuch znakow
                    // Konwertuj `Byte[]` do `string`
                    string objectSelectedToString = System.Text.Encoding.Default.GetString((Byte[])objectSelected);
                    // Konwertuj `string` do `List<string>`
                    List<string> objectSelectedToGCode = objectSelectedToString.Split(new char[] { '\n' }).ToList();
                    // Zamknij otwarty serialPort
                    CloseSerialPort();
                    // Wylacz kontrole panelu na MainForm
                    setControlPanelDisabled();
                    // Rozlacz laser
                    SetLaserDisconnected();
                    // Ustaw StatusBox na busy
                    setStatusBoxStatus(StatusBoxStatus.Busy, serialPort.PortName);

                    // Inicjalizacja procesu grawerowania, okno EngravingForm
                    try
                    {
                        EngravingForm engravingForm = new EngravingForm(
                            $"obrazu testowego {objectName}", objectSelectedToGCode
                        );
                        // Otworz jako okno dialogowe
                        engravingForm.ShowDialog();
                    }
                    catch
                    {
                        DialogResult messageBox = MessageBox.Show("Proces anulowano!",
                                "Grawerowanie",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                               );
                    }
                }
                else if (testForm.objectReference is System.Drawing.Bitmap)
                {
                    // :)
                }
            }
        }

        private void goTerminalClear_Click(object sender, EventArgs e)
        {
            listBoxTerminal.Items.Clear();
        }

        private void goTerminalCommands_Click(object sender, EventArgs e)
        {
            sendCommand("$");
        }

        private void goTerminalConfig_Click(object sender, EventArgs e)
        {
            sendCommand("$$");
            listBoxTerminal.Items.Add("[GRBL Config Start]");
        }

        private void goTerminalPosition_Click(object sender, EventArgs e)
        {
            sendCommand("?");
        }

        private void laserPower_ValueChanged(object sender, EventArgs e)
        {
            __laserPowerValue = (int)laserPower.Value;
        }

        private void menuFile_Click(object sender, EventArgs e)
        {
            // Rozwijaczka
            sidePanelShowSubMenu(panelFile);
        }

        private void menuLaser_Click(object sender, EventArgs e)
        {
            // Rozwijaczka
            sidePanelShowSubMenu(panelLaser);
        }

        private void menuSettings_Click(object sender, EventArgs e)
        {
            // Rozwijaczka
            sidePanelShowSubMenu(panelSettings);
        }

        private void menuLeave_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Wyjdź z aplikacji
        }

        private void sliderFeedrate_Scroll(object sender, EventArgs e)
        {
            __sliderFeedrateValue = (int)sliderFeedrate.Value * __sliderFeedrateRate;
            Debug.WriteLine("sliderFeedrate: \n\t-> " + sliderFeedrate.Value + "\n\t-> Value: " + __sliderFeedrateValue);
            labelSliderFeedRateValue.Text = __sliderFeedrateValue.ToString();
        }

        private void sliderStep_Scroll(object sender, EventArgs e)
        {
            __sliderStepValue = (int)sliderStep.Value * __sliderStepRate;
            Debug.WriteLine("sliderStep: \n\t-> " + sliderStep.Value + "\n\t-> Value: " + __sliderStepValue);
            labelSliderStepValue.Text = __sliderStepValue.ToString();
        }

        //================================================================================================================================================ Przyciski

        #endregion Buttons

        #region Control

        //================================================================================================================================================ Dostep uzytkownika

        /* Kontrola dostepu przy laczeniu sie z laserem
         */

        // Zmienne
        public int __laserPowerValue = 200;

        public int __sliderFeedrateValue = 0;
        public int __sliderStepValue = 0;
        private int __sliderFeedrateRate = 100;
        private int __sliderStepRate = 20;

        private void setControlPanelDisabled()
        {
            // Przyciski
            Object[] buttonsToManage = new Object[] {
                buttonUP, buttonDOWN, buttonLEFT, buttonRIGHT,
                buttonUPLEFT, buttonUPRIGHT, buttonDOWNLEFT, buttonDOWNRIGHT,
                buttonHOME, buttonLaserOn, buttonLaserOff};

            foreach (Button button in buttonsToManage)
            {
                button.BackColor = Color.FromArgb(27, 29, 37);
                button.FlatAppearance.BorderColor = Color.FromArgb(27, 29, 37);
                button.Enabled = false;
            }

            Object[] terminalButtons = new Object[] {
                goTerminalClear,
                goTerminalCommands,
                goTerminalConfig,
                goTerminalPosition,
            };
            foreach (Button button in terminalButtons)
            {
                button.Visible = false;
            }

            // Moc Lasera
            laserPower.BackColor = Color.FromArgb(125, 125, 125);
            laserPower.Enabled = false;
            commandLine.Enabled = false;
            panelCaret.Visible = false;
            sliderFeedrate.Enabled = false;
            sliderStep.Enabled = false;
            goTest.Enabled = false;
        }

        private void setControlPanelEnabled()
        {
            // Przyciski
            Object[] buttonsToManage = new Object[] {
                buttonUP, buttonDOWN, buttonLEFT, buttonRIGHT,
                buttonUPLEFT, buttonUPRIGHT, buttonDOWNLEFT, buttonDOWNRIGHT,
                buttonHOME, buttonLaserOn, buttonLaserOff};

            foreach (Button button in buttonsToManage)
            {
                button.BackColor = Color.FromArgb(0, 195, 165);
                button.FlatAppearance.BorderColor = Color.FromArgb(0, 195, 165);
                button.Enabled = true;
            }
            Object[] terminalButtons = new Object[] {
                goTerminalClear,
                goTerminalCommands,
                goTerminalConfig,
                goTerminalPosition,
            };
            foreach (Button button in terminalButtons)
            {
                button.Visible = true;
            }
            // Moc Lasera
            laserPower.BackColor = Color.FromArgb(250, 250, 250);
            laserPower.Enabled = true;

            commandLine.Enabled = true;
            panelCaret.Visible = true;

            buttonHOME.BackColor = Color.FromArgb(250, 250, 250);
            buttonLaserOn.BackColor = Color.FromArgb(67, 156, 167);
            buttonLaserOn.ForeColor = Color.White;

            buttonLaserOff.FlatAppearance.BorderColor = Color.Firebrick;
            buttonLaserOff.BackColor = Color.Firebrick;
            buttonLaserOff.ForeColor = Color.White;

            sliderFeedrate.Enabled = true;
            sliderStep.Enabled = true;

            goTest.Enabled = true;
        }

        //================================================================================================================================================ Dostep uzytkownika

        #endregion Control

        #region Connect-Disconnect

        /* Backend laczenia sie z laserem
         */

        public enum LaserStatus { Connected, Disconnected }

        public LaserStatus laserStatus = LaserStatus.Disconnected;

        public void SetLaserConnected(string portNameFound)
        {
            // Ustaw status lasera
            laserStatus = LaserStatus.Connected;
            // Pozwol uzytkownikowi na dostep do panelu
            setControlPanelEnabled();
            // System informuje o polaczeniu
            setStatusBoxStatus(StatusBoxStatus.Connected, portNameFound);
            setStatusBarMessage(DateTime.Now + " Polaczono pomyslnie z " + portNameFound);
            listBoxTerminal.Items.Add("[" + DateTime.Now + "] Connected at " + portNameFound);
            // Przycisk
            goConnect.Text = "Rozlacz";
        }

        public void SetLaserDisconnected()
        {
            // Ustaw status lasera
            laserStatus = LaserStatus.Disconnected;
            // Odbierz uzytkownikowi kontrole
            setControlPanelDisabled();
            // System informuje o rozlaczeniu
            setStatusBarMessage(DateTime.Now + " Rozlaczono z urzadzeniem");
            setStatusBoxStatus(StatusBoxStatus.Disconnected, null);
            // Przycisk
            goConnect.Text = "Polacz";
        }

        //================================================================================================================================================ Lacznosc
        public void tryConnect()
        {
            Debug.WriteLine("tryConnect():");
            // Połącz z laserem ------------------------------------------------------------------------------------------------------------------------ POLACZ
            if (laserStatus == LaserStatus.Disconnected)
            {
                // Jesli sterownik zainstalowany
                if (__isDriverInstalled)
                {
                    Debug.WriteLine("\t-> Sterownik: Zainstalowany");
                    PortFinder portFinder = new PortFinder();
                    if (portFinder.Status == PortFinder.PortFinderStatus.PortFound)
                    {
                    }
                    switch (portFinder.Status)
                    {
                        case PortFinder.PortFinderStatus.PortFound:
                            {
                                Debug.WriteLine("\t-> PortFinder: Urzadzenie podlaczone");
                                SetLaserConnected(portFinder.PortNameFound);

                                setSerialPort(portFinder.PortNameFound);
                                OpenSerialPort();
                                //
                                break;
                            }
                        case PortFinder.PortFinderStatus.PortNotFound:
                            {
                                Debug.WriteLine("\t-> PortFinder: Urzadzenie nie jest podlaczone");
                                setStatusBarMessage(DateTime.Now + " Urzadzenie nie jest podlaczone");
                                setStatusBoxStatus(StatusBoxStatus.ConnectionError, null);
                                DialogResult installDriverDialog = MessageBox.Show("Urzadzenie nie zostalo wykryte. Czy kabel zostal poprawnie podpiety?",
                                        "Nie wykryto urzadzenia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning
                                       );
                                //
                                break;
                            }
                        case PortFinder.PortFinderStatus.PortMatchError:
                            {
                                Debug.WriteLine("\t-> PortFinder: PortMatchError");
                                DialogResult installDriverDialog = MessageBox.Show("PortMatchError: Nie wykryto poprawnie urzadzenia",
                                        "PortMatchError",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error
                                       );
                                //
                                break;
                            }
                        case PortFinder.PortFinderStatus.ManagementSearcherError:
                            {
                                Debug.WriteLine("\t-> PortFinder: ManagementSearchError");
                                DialogResult installDriverDialog = MessageBox.Show("ManagementSearchError: Nie wykryto poprawnie urzadzenia",
                                        "ManagementSearchError",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error
                                       );
                                //
                                break;
                            }
                    }
                }
                else
                {
                    Debug.WriteLine("\n\t-> Sterownik: Nie zainstalowany!");
                }
            }
            // Połącz z laserem ------------------------------------------------------------------------------------------------------------------------ POLACZ
            //
            //
            //
            // Rozlacz z laserem ------------------------------------------------------------------------------------------------------------------------ ROZLACZ
            else
            {
                CloseSerialPort();
                SetLaserDisconnected();
                Debug.WriteLine("\t-> Status: Rozlaczono");
            }
            // Rozlacz z laserem ------------------------------------------------------------------------------------------------------------------------ ROZLACZ
        }

        //================================================================================================================================================ Lacznosc

        #endregion Connect-Disconnect

        #region SerialPort

        //================================================================================================================================================ SerialPort

        /*
         * Ustawienia serial port dla terminala
         */

        // SerialPort
        public SerialPort serialPort { get; set; }

        private delegate void SetTextDeleg(string text);

        public void CloseSerialPort()
        {
            // Funkcja zamykajaca polaczenie z urzadzeniem
            Debug.WriteLine("closeSerialPort():");
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    Debug.WriteLine("\t-> serialPort: Closed.");
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

        public void OpenSerialPort()
        {
            // Funkcja otwierajaca nowe polaczenie z urzadzeniem
            Debug.WriteLine("openSerialPort():");
            try
            {
                // Otworz jesli nie otwarte
                if (!(serialPort.IsOpen))
                {
                    serialPort.Open();
                }
                Debug.WriteLine("\t-> serialPort otwarty");
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

        private void setSerialPort(string portName)
        {
            /*
             * Tutaj tworzymy nowy obiekt serial port
             * Za kazdym razem kiedy wcisniemy przycisk Polacz
             */
            Debug.WriteLine($"setSerialPort('{portName}'):");
            /*
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
                    += new SerialDataReceivedEventHandler(sp_DataReceived);
                serialPort.ErrorReceived
                    += new SerialErrorReceivedEventHandler(sp_ErrorReceived);
                Debug.WriteLine($"\t-> serialPort: {serialPort.ToString()}");
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

        private void si_DataReceived(string data)
        {
            Debug.WriteLine("\tresponse-> " + data.Trim());
            // Odbierz dane i wyswietl w terminalu
            listBoxTerminal.Items.Add(data.Trim());

            // Nowe dane wyswietlane na dole terminala, zawsze pokazuj najnowsze
            int visibleItems = listBoxTerminal.ClientSize.Height / listBoxTerminal.ItemHeight;
            listBoxTerminal.TopIndex = Math.Max(listBoxTerminal.Items.Count - visibleItems + 1, 0);
        }

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Mechanizm czytania przychodzacych danych od urzadzenia
            Thread.Sleep(25);
            string data = serialPort.ReadLine();
            // Delegat odbierajacy dane z poza GUI, wysylajace dane do GUI. Inaczej sie nie da
            this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data });
        }

        private void sp_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            // Wyrzuc blad jesli nie powodzenie przy odbieraniu danych (odbierz blad)
            MessageBox.Show(
                $"SerialPort ErrorReceived: {e.EventType}",
                "SerialPort ErrorReceived Exception",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        //================================================================================================================================================ SerialPort

        #endregion SerialPort

        #region Terminal

        //================================================================================================================================================ TERMINAL
        /*
         * Wysylanie polecen to mikrokontrolera na Enter
         */

        private void commandLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && commandLine.Text.Length > 0)
            {
                sendCommand(commandLine.Text);
            }
        }

        // Wylacz laser
        private void controlPanelLaserOff()
        {
            sendCommand("M05 S0");
        }

        // Wlacz laser
        private void controlPanelLaserOn()
        {
            sendCommand(String.Format("M03 S{0}", __laserPowerValue));
        }

        // Obsluga przyciskow manualnego sterowania
        private void controlPanelMoveAction(string command)
        {
            sendCommand(
                "G91"
                );
            sendCommand(
                String.Format(command, __sliderStepValue, __sliderFeedrateValue)
                );
            sendCommand(
                "G90"
                );
        }

        public void sendCommand(string command)
        {
            Debug.WriteLine("sendCommand():\n\t-> command: " + command);

            // Uzytkownik wcisnal enter, wysyla komende do urzadzenia
            // Dodaj do terminala
            listBoxTerminal.Items.Add(
                String.Format("> {0}", command)
                );

            // Wyczysc input
            commandLine.Text = "";

            if (serialPort.IsOpen)
                serialPort.Write(command + "\r\n");
        }

        //================================================================================================================================================ TERMINAL

        #endregion Terminal

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Schowaj sideMenu + Schowaj wszystie podopcje w sideMenu
            sidePanelHide();

            listBoxTerminal.Items.Add("AOGL 1.0");

            // Sprawdź stan sterownika
            checkDriverInstalled();

            // Laser disconnected
            laserStatus = LaserStatus.Disconnected;
            SetLaserDisconnected();
            setStatusBarMessage(DateTime.Now + " Witamy w aplikacji obsługi grawera laserowego.");

            __laserPowerValue = (int)laserPower.Value;
            __sliderFeedrateValue = (int)sliderFeedrate.Value * __sliderFeedrateRate;
            __sliderStepValue = (int)sliderStep.Value * __sliderStepRate;
            labelSliderFeedRateValue.Text = (sliderFeedrate.Value * __sliderFeedrateRate).ToString();
            labelSliderStepValue.Text = (sliderStep.Value * __sliderStepRate).ToString();

            welcomeForm = new WelcomeForm(this)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            tabControl.TabPages[0].Controls.Add(welcomeForm);
            welcomeForm.Show();

            // Load Latest Files
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\last.aogl"))
            {
                Debug.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\last.aogl");
                loadFilesToWelcome();
            }
            else
            {
                Debug.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\last.aogl doesnt exist");
                File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\last.aogl");
            }
        }

        private void goGrbl_Click(object sender, EventArgs e)
        {
            sidePanelHide();
            GRBLConfigurationForm grblConfig = new GRBLConfigurationForm(this)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            TabPage grblPage = new TabPage("Konfiguracja GRBL");
            grblPage.Controls.Add(grblConfig);
            tabControl.Controls.Add(grblPage);
            tabControl.SelectedTab = grblPage;
            grblConfig.Show();
        }
    }
}