using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace aogl1
{
    class DriverManager
    {
        public const string driverConst = "CH341SER";
        public enum DriverStatus { DriverNotFound, DriverFound }
        public DriverStatus Status { get; set; }
        private string DriverNameFound { get; set; }

        public DriverManager() { Status = runDriverQuery(); }

        public DriverStatus runDriverQuery()
        {
            // Szukaj sterownika CH341SER w spisie systemowym
            ManagementObjectCollection mgmtObjCollection = null;
            // Query do WMI
            string mgmtObjQuery = String.Format(
                "Select * From Win32_SystemDriver WHERE Name LIKE \"{0}%\"", driverConst
                );
            ManagementObjectSearcher mgmtObjSearcher = new ManagementObjectSearcher(mgmtObjQuery);
            mgmtObjCollection = mgmtObjSearcher.Get();

            // Jeśli istnieje CH341SER
            if (mgmtObjCollection.Count > 0)
            {
                ManagementObject mgmtObj = mgmtObjCollection.OfType<ManagementObject>().FirstOrDefault();
                this.DriverNameFound = mgmtObj["Name"].ToString();
                return DriverStatus.DriverFound;
            }
            else
            {
                return DriverStatus.DriverNotFound;
            }
        }

        public string Get()
        {
            return this.DriverNameFound;
        }
    }
}
