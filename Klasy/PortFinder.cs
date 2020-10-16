using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.IO.Ports;
using System.Windows.Forms;


namespace GrawerTerminal
{
    class PortFinder
    {
        //x
        public enum PortFinderStatus {
            PortNotFound, // Portu nie znaleziono
            PortFound, // Port znaleziono
            PortMatchError, // Portu nie wykryto
            ManagementSearcherError, // Błąd przy wyszukiwaniu portu
        };
        public PortFinderStatus Status;
        public string PortNameFound;

        //ctor
        public PortFinder() {
            Status = findPort();
        }

        public string Get()
        {
            return this.PortNameFound;
        }

        //f(x)
        public PortFinderStatus findPort()
        {
            try
            {
                // Wykryte COMy
                List<string> SerialPorts = new List<string>();
                foreach(string device in SerialPort.GetPortNames())
                {
                    SerialPorts.Add(device.ToString());
                }

                // Wykrywanie maszyny
                string query = "SELECT * FROM Win32_PnPEntity WHERE Name LIKE \"%CH34%\"";
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
                ManagementObjectCollection collection = searcher.Get();
                if (collection.Count > 0)
                {
                    // Sprawdzanie poprawności
                    string found = collection.OfType<ManagementObject>().FirstOrDefault()["Name"].ToString();
                    foreach(string port in SerialPorts)
                    {
                        if (found.Contains(port))
                        {
                            this.PortNameFound = port.ToString();
                            return PortFinderStatus.PortFound;
                        }
                    }
                    return PortFinderStatus.PortMatchError;
                }
                else
                {
                    return PortFinderStatus.PortNotFound;
                }
            }
            catch (ManagementException e)
            {
                MessageBox.Show(e.Message);
                return PortFinderStatus.ManagementSearcherError;
            }
            return PortFinderStatus.PortFound;

        }
    }
}
