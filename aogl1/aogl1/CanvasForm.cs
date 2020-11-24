using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aogl1
{
    public partial class CanvasForm : Form
    {
        public CanvasForm()
        {
            InitializeComponent();

            CanvasPicture canvasPicture = new CanvasPicture()
            {
                TopLevel = false,
                TopMost = true
            };
            panelShowcase.Controls.Add(canvasPicture);
            canvasPicture.Show();
        }

        private void goClose_Click(object sender, EventArgs e)
        {
            // Zamknij
            this.Close();
            
            
        }

        private void goSimulate_Click(object sender, EventArgs e)
        {
            // Symuluj
        }

        private void goEngrave_Click(object sender, EventArgs e)
        {
            // Graweruj
        }
    }
}
