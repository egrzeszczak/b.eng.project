using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOGL
{
    public partial class WarningForm : Form
    {
        public bool OK = false;
        public WarningForm()
        {
            InitializeComponent();
        }

        private void goAllow_Click(object sender, EventArgs e)
        {
            OK = true;
            this.Close();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            OK = false;
            this.Close();
        }
    }
}
