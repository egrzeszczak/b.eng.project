using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOGL
{
    public partial class GCodeForm : Form
    {
        /*
         * GCodeForm przyjmuje:
         * - Obiekt SerialPort
         * - Obiekt TabControl
         * - absolutna sciezke do pliku
         */
        private string __fileName;
        private List<string> __gcode;
        private TabControl __ownerTab;
        private SerialPort __serialPort;
        public GCodeForm(SerialPort serialPort, TabControl ownerTab, string fileName)
        {
            InitializeComponent();
            __serialPort = serialPort;
            __fileName = fileName;
            __ownerTab = ownerTab;
            __gcode = new List<string>();
        }
        public GCodeForm(SerialPort serialPort, TabControl ownerTab, string fileName, List<string> gcode)
        {
            InitializeComponent();
            __serialPort = serialPort;
            __ownerTab = ownerTab;
            __fileName = fileName;
            __gcode = gcode;
        }

        public int getWidth()
        {
            int initWidth;
            // get total lines of richTextBox1    
            int line = richTextBox1.Lines.Length;

            if (line <= 99)
            {
                initWidth = 40 + (int)richTextBox1.Font.Size;
            }
            else if (line <= 999)
            {
                initWidth = 60 + (int)richTextBox1.Font.Size;
            }
            else
            {
                initWidth = 60 + (int)richTextBox1.Font.Size;
            }

            return initWidth;
        }
        public void AddLineNumbers()
        {
            // create & set Point pt to (0,0)    
            Point pt = new Point(0, 0);
            // get First Index & First Line from richTextBox1    
            int First_Index = richTextBox1.GetCharIndexFromPosition(pt);
            int First_Line = richTextBox1.GetLineFromCharIndex(First_Index);
            // set X & Y coordinates of Point pt to ClientRectangle Width & Height respectively    
            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;
            // get Last Index & Last Line from richTextBox1    
            int Last_Index = richTextBox1.GetCharIndexFromPosition(pt);
            int Last_Line = richTextBox1.GetLineFromCharIndex(Last_Index);
            // set Center alignment to LineNumberTextBox    
            LineNumberTextBox.SelectionAlignment = HorizontalAlignment.Center;
            // set LineNumberTextBox text to null & width to getWidth() function value    
            LineNumberTextBox.Text = "";
            LineNumberTextBox.Width = getWidth();
            // now add each line number to LineNumberTextBox upto last line    
            for (int i = First_Line; i <= Last_Line + 2; i++)
            {
                LineNumberTextBox.Text += i + 1 + "\n";
            }
        }

        private void GCodeForm_Load(object sender, EventArgs e)
        {
            LineNumberTextBox.Font = richTextBox1.Font;
            richTextBox1.Select();
            AddLineNumbers();

            // Wybrano z pliku?
            if (!Boolean.Equals(__fileName, null))
            {
                // Tak, wybrano z opcji Laduj plik GCode
                openTextFile(__fileName);
            } 
            else
            {
                // Nie, przekonwertowano w programie
                openGCodeList(__gcode);
            }
        }

        private void openGCodeList(List<string> gcode)
        {
            // Wczytaj linie do richTextBoxa
            richTextBox1.Lines = gcode.ToArray();
        }

        private void openTextFile(string fileName)
        {
            try
            {
                StreamReader reader = new StreamReader(fileName);

                string buffer = "";
                while ((buffer = reader.ReadLine()) != null)
                {
                    __gcode.Add(buffer);
                }
                for (int i = 0; i < 5; i++)
                {
                    __gcode.Add(String.Empty);
                }
                openGCodeList(__gcode);
            }
            catch (Exception)
            {
                //Catch exception
            }
        }



        private void GCodeForm_Resize(object sender, EventArgs e)
        {
            AddLineNumbers();
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            Point pt = richTextBox1.GetPositionFromCharIndex(richTextBox1.SelectionStart);
            if (pt.X == 1)
            {
                AddLineNumbers();
            }
        }

        private void richTextBox1_VScroll(object sender, EventArgs e)
        {
            LineNumberTextBox.Text = "";
            AddLineNumbers();
            LineNumberTextBox.Invalidate();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                AddLineNumbers();
            }
        }

        private void richTextBox1_FontChanged(object sender, EventArgs e)
        {
            LineNumberTextBox.Font = richTextBox1.Font;
            richTextBox1.Select();
            AddLineNumbers();
        }

        private void LineNumberTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBox1.Select();
            LineNumberTextBox.DeselectAll();
        }

        private void goClose_Click(object sender, EventArgs e)
        {
            __ownerTab.TabPages.Remove(__ownerTab.SelectedTab);
            this.Close();
        }


        private void goEngrave_Click(object sender, EventArgs e)
        {
            if(!Boolean.Equals(__serialPort, null))
            {
                if (__serialPort.IsOpen)
                {
                    __serialPort.Close();
                }
            }
            
            EngravingForm engravingForm = new EngravingForm(
                __fileName, __gcode
            );
            engravingForm.ShowDialog();
        }
    }
}
