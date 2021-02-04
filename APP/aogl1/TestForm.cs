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

namespace AOGL
{
    public partial class TestForm : Form
    {
        public Object objectReference { get; set; }
        public string objectName { get; set; }

        public class TestingObject : Button
        {
            public Object Content;
            public TestForm tf;
            public TestingObject(string __text, Image __image, Object __resourceObject, TestForm __testForm)
            {
                this.Text = __text;
                this.Image = __image;

                this.Dock = DockStyle.Top;
                this.Height = 50;
                this.BackColor = Color.FromArgb(40, 43, 51);
                this.ForeColor = Color.White;
                this.Font = new Font("Microsoft YaHei", 10F, FontStyle.Regular);
                this.FlatStyle = FlatStyle.Flat;
                this.FlatAppearance.BorderColor = Color.FromArgb(35, 38, 46);
                this.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 195, 165);
                this.Cursor = Cursors.Hand;
                this.ImageAlign = ContentAlignment.MiddleLeft;
                this.Content = __resourceObject;
                this.Click += TestingObject_Click;
                this.tf = __testForm;
            }

            private void TestingObject_Click(object sender, EventArgs e)
            {
                tf.objectReference = this.Content;
                tf.objectName = this.Text;
                Debug.WriteLine(tf.objectReference.ToString());
                tf.Close();
            }
        }

        public TestForm()
        {
            InitializeComponent();
            loadTestingObjects();
        }

        private void loadTestingObjects()
        {
            TestingObject[] testingObjects =
            {
                new TestingObject("Pepe (Instrukcje GCode)", Properties.Resources.pepe32x32, Properties.Resources.pepe_gcode, this),
                new TestingObject("Panda (Instrukcje GCode)", Properties.Resources.panda32x32, Properties.Resources.panda_gcode, this),
                new TestingObject("Tekst TEST (Instrukcje GCode)", Properties.Resources.test32x32, Properties.Resources.test_gcode, this),
                new TestingObject("Pepe (Obraz JPG)", Properties.Resources.pepe32x32, Properties.Resources.pepe, this),
                new TestingObject("Panda (Obraz PNG)", Properties.Resources.panda32x32, Properties.Resources.panda, this), 
                new TestingObject("Tekst TEST (Obraz PNG)", Properties.Resources.test32x32, Properties.Resources.test, this)
            };
            foreach (TestingObject test in testingObjects)
            {
                panelTests.Controls.Add(test);
            }
        }


        private void goCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
