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
            mainForm.goLoadFile_Click(sender, e);
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
            if(mainForm.laserStatus == MainForm.LaserStatus.Connected)
            {
                mainForm.goTest_Click(sender, e);
            }
        }

        private void goLoadGCode_Click(object sender, EventArgs e)
        {
            mainForm.goLoadGCode_Click(sender, e);
        }
    }
}
