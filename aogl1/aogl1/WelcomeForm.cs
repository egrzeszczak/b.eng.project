using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOGL
{
    public partial class WelcomeForm : Form
    {
        private MainForm mainForm;
        public WelcomeForm(MainForm __mainForm)
        {
            mainForm = __mainForm;
            InitializeComponent();
        }

        private void goOpenFile_Click(object sender, EventArgs e)
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
                //Nowa zakladka
                TabPage loadFileTab = new TabPage(Path.GetFileNameWithoutExtension(openFile.FileName) + $" (Obraz {Path.GetExtension(openFile.FileName)})");
                //Ustawienia dla CanvasForm
                CanvasForm canvasForm = new CanvasForm(mainForm.serialPort, openFile.FileName, mainForm.tabControl)
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                };
                //Dodaj do nowej zakladki canvasForm
                loadFileTab.Controls.Add(canvasForm);
                //Dodaj nowa zakladke do TabControl
                mainForm.tabControl.Controls.Add(loadFileTab);
                //Wybierz ta zakladke
                mainForm.tabControl.SelectedTab = loadFileTab;
                //Pokaz
                canvasForm.Show();
            }
            else { }
        }

        private void goGRBLConfig_Click(object sender, EventArgs e)
        {
            GRBLConfigurationForm grblConfig = new GRBLConfigurationForm(mainForm)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            TabPage grblPage = new TabPage("Konfiguracja GRBL");
            grblPage.Controls.Add(grblConfig);
            mainForm.tabControl.Controls.Add(grblPage);
            mainForm.tabControl.SelectedTab = grblPage;
            grblConfig.Show();
        }

        private void goConnect_Click(object sender, EventArgs e)
        {
            mainForm.tryConnect();
        }

        private void goTest_Click(object sender, EventArgs e)
        {
            mainForm.goTest_Click(sender, e);
        }
    }
}
