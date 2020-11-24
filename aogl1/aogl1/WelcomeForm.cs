using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace aogl1
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            loadRecentFilesPaths();
        }

        public void loadRecentFilesPaths()
        {
            var directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            List<string> paths = File.ReadAllLines(Path.Combine(directory, "AOGL", "recentFiles.txt")).ToList();

            switch (paths.Count)
            {
                case 6: goto case 5;
                case 5: recentFileLabel5.Text = paths[4]; goto case 4;
                case 4: recentFileLabel4.Text = paths[3]; goto case 3;
                case 3: recentFileLabel3.Text = paths[2]; goto case 2;
                case 2: recentFileLabel2.Text = paths[1]; goto case 1;
                case 1: recentFileLabel1.Text = paths[0]; break;

            }
            System.Console.WriteLine("paths.count={0:D}", paths.Count);
            /*
            using (FileStream fs = File.OpenRead(Path.Combine(directory, "AOGL", "recentFiles.txt"))) {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    recentFileLabel1.Text = temp.GetString(b);
                }
            } */

        }
    
}
}
