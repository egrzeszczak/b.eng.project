using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AOGL.MainForm;

namespace AOGL
{
    public partial class GRBLConfigurationForm : Form
    {
        public class GRBLOption
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Value { get; set; }

            public OptionType Type { get; set; }
            public enum OptionType { Boolean, Mask, Float, Int }

            public GRBLOption(int __ID, string __Name, string __Description, string __Value, OptionType __Type)
            {
                ID = __ID;
                Name = __Name;
                Description = __Description;
                Value = __Value;
                Type = __Type;
            }

            public ListViewItem ToListViewItem()
            {
                ListViewItem listViewItem = new ListViewItem(new string[] { ID.ToString(), Name.ToString(), Description.ToString(), Value.ToString() });
                return listViewItem;
            }
        }

        public MainForm mainForm;
        public List<string> currentConfiguration;
        public List<GRBLOption> options;

        public GRBLConfigurationForm(MainForm __MainForm)
        {
            InitializeComponent();
            mainForm = __MainForm;

            options = new List<GRBLOption>();
            options.Add(new GRBLOption(0, "Step pulse", "usec", "0", GRBLOption.OptionType.Int));
            options.Add(new GRBLOption(1, "Step idle delay", "msec", "", GRBLOption.OptionType.Int));
            options.Add(new GRBLOption(2, "Step port invert", "mask: 00000000", "0", GRBLOption.OptionType.Mask));
            options.Add(new GRBLOption(3, "Dir port invert", "mask: 00000000", "0", GRBLOption.OptionType.Mask));
            options.Add(new GRBLOption(4, "Step enable invert", "bool", "0", GRBLOption.OptionType.Boolean));
            options.Add(new GRBLOption(5, "Limit pins invert", "bool", "0", GRBLOption.OptionType.Boolean));
            options.Add(new GRBLOption(6, "Probe pin invert", "bool", "0", GRBLOption.OptionType.Boolean));
            options.Add(new GRBLOption(10, "Status report", "mask: 00000011", "0", GRBLOption.OptionType.Mask));
            options.Add(new GRBLOption(11, "Junction deviation", "mm", "0", GRBLOption.OptionType.Float));
            options.Add(new GRBLOption(12, "Arc tolerance", "mm", "0", GRBLOption.OptionType.Float));
            options.Add(new GRBLOption(13, "Report inches", "bool", "0", GRBLOption.OptionType.Boolean));
            options.Add(new GRBLOption(20, "Soft limits", "bool", "0", GRBLOption.OptionType.Boolean));
            options.Add(new GRBLOption(21, "Hard limits", "bool", "0", GRBLOption.OptionType.Boolean));
            options.Add(new GRBLOption(22, "Homing cycle", "bool", "0", GRBLOption.OptionType.Boolean));
            options.Add(new GRBLOption(23, "Homing dir invert", "mask: 00000000", "0", GRBLOption.OptionType.Mask));
            options.Add(new GRBLOption(24, "Homing feed", "mm/min", "0", GRBLOption.OptionType.Float));
            options.Add(new GRBLOption(25, "Homing seed", "mm/min", "0", GRBLOption.OptionType.Float));
            options.Add(new GRBLOption(26, "Homing debounce", "msec", "0", GRBLOption.OptionType.Int));
            options.Add(new GRBLOption(27, "Homing pull-off", "mm", "0", GRBLOption.OptionType.Float));
            options.Add(new GRBLOption(100, "X", "step/mm", "0", GRBLOption.OptionType.Float));
            options.Add(new GRBLOption(101, "Y", "step/mm", "0", GRBLOption.OptionType.Float));
            options.Add(new GRBLOption(102, "Z", "step/mm", "0", GRBLOption.OptionType.Float));
            options.Add(new GRBLOption(110, "X max rate", "mm/min", "0", GRBLOption.OptionType.Float));
            options.Add(new GRBLOption(111, "Y max rate", "mm/min", "0", GRBLOption.OptionType.Float));
            options.Add(new GRBLOption(112, "Z max rate", "mm/min", "0", GRBLOption.OptionType.Float));
            options.Add(new GRBLOption(120, "X acceleration", "mm/sec^2", "0", GRBLOption.OptionType.Float));
            options.Add(new GRBLOption(121, "Y acceleration", "mm/sec^2", "0", GRBLOption.OptionType.Float));
            options.Add(new GRBLOption(122, "Z acceleration", "mm/sec^2", "0", GRBLOption.OptionType.Float));
            options.Add(new GRBLOption(130, "X max travel", "mm", "0", GRBLOption.OptionType.Float));
            options.Add(new GRBLOption(131, "Y max travel", "mm", "0", GRBLOption.OptionType.Float));
            options.Add(new GRBLOption(132, "Z max travel", "mm", "0", GRBLOption.OptionType.Float));

            PopulateListView();
        }

        private void PopulateListView()
        {
            listOptions.Items.Clear();
            foreach (GRBLOption option in options)
            {
                listOptions.Items.Add(option.ToListViewItem());
            }
        }

        private void goFetchConfig_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listOptions.Items)
            {
                item.ForeColor = Color.White;
            }
            FetchConfiguration();
        }

        public SerialPort fetchedSerialPort;

        private void FetchConfiguration()
        {
            if(mainForm.laserStatus == LaserStatus.Connected)
            {
                mainForm.CloseSerialPort();
                mainForm.SetLaserDisconnected();

                fetchedSerialPort = new SerialPort(
                        mainForm.serialPort.PortName,
                        mainForm.serialPort.BaudRate,
                        mainForm.serialPort.Parity,
                        mainForm.serialPort.DataBits,
                        mainForm.serialPort.StopBits
                    );
                fetchedSerialPort.Handshake = Handshake.None;
                fetchedSerialPort.ReadTimeout = 500;
                fetchedSerialPort.WriteTimeout = 500;
                fetchedSerialPort.DataReceived +=
                    new SerialDataReceivedEventHandler(ConfigurationReceived);

                fetchedSerialPort.Open();


                currentConfiguration = new List<string>();
                fetchedSerialPort.Write("$$\n");

                Thread.Sleep(250);

                fetchedSerialPort.Close();

                mainForm.OpenSerialPort();
                mainForm.SetLaserConnected(new PortFinder().PortNameFound);
            }
        }
        private delegate void ConfigurationDelegate(string configrationLine);
        private void ConfigurationReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string DataReceived = fetchedSerialPort.ReadLine();
            this.BeginInvoke(new ConfigurationDelegate(FetchConfiugurationData), new object[] { DataReceived });
        }

        private char[] configurationFetchDelimiter = { '$', '=', ' ' };
        private void FetchConfiugurationData(string configrationLine)
        {
            if (configrationLine.Length > 3 && configrationLine.StartsWith("$"))
            {
                string[] settingString = configrationLine.Split(configurationFetchDelimiter);
                settingString = settingString.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                Debug.WriteLine("Fetched: " + settingString[0] + ", " + settingString[1]);

                options.Where(i => i.ID == int.Parse(settingString[0])).First().Value = settingString[1];

                foreach (ListViewItem item in listOptions.Items)
                {
                    if(item.SubItems[0].Text == settingString[0])
                    {
                        item.SubItems[3].Text = settingString[1];
                    }
                }
            }
        }

        private void GRBLConfigurationForm_Load(object sender, EventArgs e)
        {
            listOptions.AutoResizeColumn(0,
                ColumnHeaderAutoResizeStyle.HeaderSize);
            listOptions.AutoResizeColumn(1,
                ColumnHeaderAutoResizeStyle.ColumnContent);
            listOptions.AutoResizeColumn(2,
                ColumnHeaderAutoResizeStyle.ColumnContent);
            listOptions.AutoResizeColumn(3,
                ColumnHeaderAutoResizeStyle.HeaderSize);

            FetchConfiguration();
        }

        private void listOptions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GRBLConfigEditForm editForm = new GRBLConfigEditForm();

            editForm.Text = "Zmien $" + listOptions.SelectedItems[0].SubItems[0].Text;
            editForm.labelOption.Text = listOptions.SelectedItems[0].SubItems[1].Text + " (" + listOptions.SelectedItems[0].SubItems[2].Text + ")";
            // Value
            editForm.inputOption.Text = listOptions.SelectedItems[0].SubItems[3].Text;
            editForm.ShowDialog();

            if (editForm.Status == GRBLConfigEditForm.Changed.Yes && listOptions.SelectedItems[0].SubItems[3].Text != editForm.inputOption.Text)
            {
                listOptions.SelectedItems[0].SubItems[3].Text = editForm.inputOption.Text;
                listOptions.SelectedItems[0].ForeColor = Color.FromArgb(0, 195, 165);
                listOptions.SelectedItems.Clear();
            } else { }
        }

        private void goWriteConfig_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listOptions.Items)
            {
                if(item.ForeColor == Color.FromArgb(0, 195, 165))
                {
                    if (mainForm.serialPort.IsOpen)
                    {
                        mainForm.sendCommand($"${item.SubItems[0].Text}={item.SubItems[3].Text}\n\r");
                        item.ForeColor = Color.White;
                    }
                }
            }
        }

        private void goSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "grbl config files (*.grcf)|*.grcf";
            sfd.FilterIndex = 0;
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                foreach (ListViewItem item in listOptions.Items)
                {
                    sw.WriteLine($"${item.SubItems[0].Text}={item.SubItems[3].Text}");
                }
                sw.Close();
            }
        }

        private void goLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "grbl config files (*.grcf)|*.grcf|Wszystkie pliki tekstowe (*.txt)|*.txt";
            ofd.FilterIndex = 1;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                while (!sr.EndOfStream)
                {
                    string[] data = sr.ReadLine().Split(configurationFetchDelimiter);
                    data = data.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                    foreach (ListViewItem item in listOptions.Items)
                    {
                        if(item.SubItems[0].Text == data[0])
                        {
                            if(item.SubItems[3].Text == data[1])
                            {
                                // Bez zmian
                            } else
                            {
                                item.SubItems[3].Text = data[1];
                                item.ForeColor = Color.FromArgb(0, 195, 165);
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.tabControl.TabPages.Remove(mainForm.tabControl.SelectedTab);
            this.Close();
        }
    }
}
