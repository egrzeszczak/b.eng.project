using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOGL
{
    public partial class CanvasPicture : Form
    {
        private Point MouseDownLocation;

        private NReco.ImageGenerator.HtmlToImageConverter svgImage = new NReco.ImageGenerator.HtmlToImageConverter();

        public enum ImageType { Raster, Vector }
        private ImageType imageType;
        public CanvasPicture(string fileName, Size parentSize)
        {
            InitializeComponent();

            this.Size = parentSize;
            if (fileName.EndsWith(".svg"))
            {
                imageType = ImageType.Vector;
                var imageByte = svgImage.GenerateImageFromFile(fileName, "png");
                var stream = new System.IO.MemoryStream(imageByte, 0, imageByte.Length);
                pictureBox.Image = new Bitmap(Image.FromStream(stream));
            } 
            else
            {
                imageType = ImageType.Raster;
                pictureBox.Image = new Bitmap(fileName);
            }
            this.Location = new Point(0, 0);
            this.Refresh();
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

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
