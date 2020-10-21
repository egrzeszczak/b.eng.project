using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aogl1
{
    public partial class MainForm : Form
    {

        public enum LaserStatus { Connected, Disconnected }
        
        public MainForm()
        {
            InitializeComponent();

            //Schowaj sideMenu + Schowaj wszystie podopcje w sideMenu
            sidePanelCollapse();
            sidePanelHideAll();
        }

        #region SideMenu

        /*  Region SideMenu
         *  Funkcje obsługi bocznego panelu menu
         */
        private void sidePanelHideAll()
        {
            // Schowaj wszystkie podopcje
            panelFile.Visible = false;
            panelSettings.Visible = false;
            panelLaser.Visible = false;
        }

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
            } else
            {
                // Ponowne kliknięcie na rozwinięte menu chowa menu
                sidePanelCollapse();
                subMenu.Visible = false;
            }
        }

        #endregion

        #region DriverManager

        /* Region DriverManager
         * Funkcje odpowiedzialne za wychwytywanie sterownika z systemu
         */
        private DriverManager.DriverStatus checkForInstalledDriver()
        {
            // Klasa DriverManager
            DriverManager driverManager = new DriverManager();
            return driverManager.Status;
        }

        private void driverManagerRoutine()
        {
            // Sprawdź obecność sterownikia
            DriverManager.DriverStatus driverStatus = checkForInstalledDriver();
            Debug.WriteLine(driverStatus);

            // Czy sterownik zainstalowany
            if (driverStatus == DriverManager.DriverStatus.DriverNotFound)
            {
                // Sterownika nie znaleziono. Przekaż złą wiadomość użytkownikowi
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
                    /*
                     *  <-------- TUTAJ KOD
                     */ 
                }
                else
                {
                    // Użytkownik nie chce zainstalować sterownika
                    Debug.WriteLine("Użytkownik nie chce zainstalować sterownika");
                }
            } else
            {
                // Sterownik znaleziony
                goDriver.Enabled = false;
                goDriver.Text = "Sterownik zainstalowany";
            }
        }
        #endregion

        #region StatusBar

        /* Region StatusBar
         * Funkcje odpowiedzialne za wyświetlanie statusu w dolnym panelu
         */
        private void setStatusBarMessage(string message)
        {
            textStatus.Text = message;
        }

        public enum StatusBoxStatus { Connected, Disconnected, ConnectionError }
        private void setStatusBox(StatusBoxStatus status)
        {
            switch (status)
            {
                case StatusBoxStatus.Connected:
                    {
                        textStatusBox.Text = "OK (COM4)";
                        textStatusBox.BackColor = Color.FromArgb(143, 255, 104);
                        textStatusBox.ForeColor = Color.Black;
                        break;
                    }
                case StatusBoxStatus.Disconnected:
                    {
                        textStatusBox.Text = "DISCONN";
                        textStatusBox.BackColor = Color.FromArgb(53, 53, 53);
                        textStatusBox.ForeColor = SystemColors.ControlDarkDark;
                        break;
                    }
                case StatusBoxStatus.ConnectionError:
                    {
                        textStatusBox.Text = "ERR";
                        textStatusBox.BackColor = Color.FromArgb(234, 86, 72);
                        textStatusBox.ForeColor = Color.White;
                        break;
                    }
            }

        }


        #endregion

        #region Buttons

        /* Przyciski
         * Chyba proste nie?
         */
        private void menuFile_Click(object sender, EventArgs e)
        {
            // Rozwijaczka
            sidePanelShowSubMenu(panelFile); 
        }

        private void menuSettings_Click(object sender, EventArgs e)
        {
            // Rozwijaczka
            sidePanelShowSubMenu(panelSettings);
        }

        private void menuLaser_Click(object sender, EventArgs e)
        {
            // Rozwijaczka
            sidePanelShowSubMenu(panelLaser);
        }

        private void menuLeave_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Wyjdź z aplikacji
        }
        private void goLeave_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Wyjdź z aplikacji
        }
        private void goLoadFile_Click(object sender, EventArgs e)
        {
            // Ładowanie pliku .svg, .jpg, .png
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Obrazy JPG (.jpg)|*.jpg|Obrazy PNG (.png)|*.png|Obrazy wektorowe (.svg)|*.svg";
            openFile.FilterIndex = 1;
            openFile.ShowDialog();
        }

        private void goLoadGCode_Click(object sender, EventArgs e)
        {
            // Ładowanie pliku .nc, .gcode, .txt
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Instrukcje GCode|*.nc|Instrukcje GCode|*.gcode|Pliki tekstowe (.txt)|*.txt";
            openFile.FilterIndex = 1;
            openFile.ShowDialog();
        }


        private void goExport_Click(object sender, EventArgs e)
        {
            // Zapisz plik z instrukcjami
        }

        private void goConnect_Click(object sender, EventArgs e)
        {
            // Połącz z laserem
        }

        private void goDriver_Click(object sender, EventArgs e)
        {
            // Zainstaluj sterownik (wtedy kiedy na wejściu użytkownik sobie tego nieżyczył)
        }

        private void goTest_Click(object sender, EventArgs e)
        {
            // Wykonaj grawer testowy
        }
        #endregion

        #region Control

        private void enableControl()
        {
            commandLine.Enabled =
            listBoxTerminal.Enabled =
            labelCaret.Visible =
            panelControlSliders.Enabled =
            sliderFeedrate.Enabled =
            sliderStep.Enabled =
            panelControlButtons.Enabled =
            buttonDOWN.Enabled =
            buttonUP.Enabled =
            buttonLEFT.Enabled =
            buttonRIGHT.Enabled =
            buttonUPLEFT.Enabled =
            buttonUPRIGHT.Enabled =
            buttonDOWNLEFT.Enabled =
            buttonDOWNRIGHT.Enabled =
            buttonHOME.Enabled =
            buttonLaserOff.Enabled =
            buttonLaserOn.Enabled =
            laserPower.Enabled = true;
        }

        private void disableControl()
        {
            // To napewno tak nie zostanie :)
            commandLine.Enabled = 
            listBoxTerminal.Enabled = 
            labelCaret.Visible = 
            panelControlSliders.Enabled = 
            sliderFeedrate.Enabled = 
            sliderStep.Enabled =
            panelControlButtons.Enabled = 
            buttonDOWN.Enabled =
            buttonUP.Enabled =
            buttonLEFT.Enabled =
            buttonRIGHT.Enabled =
            buttonUPLEFT.Enabled =
            buttonUPRIGHT.Enabled =
            buttonDOWNLEFT.Enabled =
            buttonDOWNRIGHT.Enabled =
            buttonHOME.Enabled =
            buttonLaserOff.Enabled =
            buttonLaserOn.Enabled =
            laserPower.Enabled = false;
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Sprawdź stan sterownika
            driverManagerRoutine();

            // Dolny panelStatus
            setStatusBox(StatusBoxStatus.Disconnected);
            setStatusBarMessage("Witamy w aplikacji obsługi grawera laserowego. Developer stage");

            // Przy braku połączenia z laserem zabierz kontrole
            listBoxTerminal.Items.Add("Aby połączyć się z laserem, wybierz Laser > Połącz");
            disableControl();
        }

        
    }
}
