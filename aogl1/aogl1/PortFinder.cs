using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOGL
{
    class PortFinder
    {
        public enum PortFinderStatus
        {
            PortNotFound, // Portu nie znaleziono
            PortFound, // Port znaleziono
            PortMatchError, // Portu nie wykryto
            ManagementSearcherError, // Błąd przy wyszukiwaniu portu
        };
        public PortFinderStatus Status;
        public string PortNameFound;

        public PortFinder()
        {
            Status = findPort();
        }

        public string Get()
        {
            return this.PortNameFound;
        }

        public PortFinderStatus findPort()
        {
            try
            {
                // Wykryte COMy
                List<string> SerialPorts = new List<string>();
                foreach (string device in SerialPort.GetPortNames())
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
                    foreach (string port in SerialPorts)
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
            catch
            {
                return PortFinderStatus.ManagementSearcherError;
            }
        }
    }
}
