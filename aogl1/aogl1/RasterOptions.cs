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
    public partial class RasterOptions : Form
    {
        private string Filename;

        public int Feedrate { get; set;  }
        public float MinPower { get; set;  }
        public float MaxPower { get; set;  }
        public string Style { get; set; }

        public bool Status = false;
        public RasterOptions(string __filename)
        {
            Filename = __filename;
            InitializeComponent();
        }

        private void RasterOptions_Load(object sender, EventArgs e)
        {
            this.Text = $"Opcje generowania instrukcji {Filename}";
            styleBox.Items.AddRange(new object[]
            {
                GCodeFromImage.RasterToGCode.Style.Horizontal.ToString(),
                GCodeFromImage.RasterToGCode.Style.Vertical.ToString(),
                GCodeFromImage.RasterToGCode.Style.OnlyBlack.ToString(),
            });
            //styleBox.SelectedText = "Horizontal";
        }

        private void goOK_Click(object sender, EventArgs e)
        {
            int _feedrate = int.Parse(feedRateBox.Text);
            float _maxpower = float.Parse(powerMaxBox.Text);
            float _minpower = float.Parse(powerMinBox.Text);
            string style = styleBox.Text;

            if (
                _maxpower >= _minpower &&
                _feedrate >= 100
                )
            {
                Feedrate = _feedrate;
                MaxPower = _maxpower;
                MinPower = _minpower;
                Style = style;
                Status = true;
                this.Close();
            } 
            else
            {
                Status = false;
            }

        }

        private void goBack_Click(object sender, EventArgs e)
        {
            Status = false;
            this.Close();
        }
    }
}
