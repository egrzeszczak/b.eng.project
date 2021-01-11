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
    public partial class GRBLConfigEditForm : Form
    {
        public enum Changed { Yes, No }
        public Changed Status { get; set; }
        public GRBLConfigEditForm()
        {
            InitializeComponent();
            this.Status = Changed.No;
        }

        private void goOK_Click(object sender, EventArgs e)
        {
            this.Status = Changed.Yes;
            this.Close();
        }

        private void goCancel_Click(object sender, EventArgs e)
        {
            this.Status = Changed.No;
            this.Close();
        }

        private void inputOption_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.Status = Changed.Yes;
                this.Close();
            }
        }
    }
}
