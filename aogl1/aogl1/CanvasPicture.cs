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
    public partial class CanvasPicture : Form
    {
        private Point MouseDownLocation;

        public CanvasPicture(string fileName)
        {
            InitializeComponent();

            pictureBox.Image = new Bitmap(fileName);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.Anchor = AnchorStyles.None;
            pictureBox.Location = new Point((pictureBox.Parent.ClientSize.Width / 2) - (pictureBox.Width / 2),
                              (pictureBox.Parent.ClientSize.Height / 2) - (pictureBox.Height / 2));
            pictureBox.Refresh();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }
    }
}
