using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.IO.Ports;
using System.Threading;

namespace GrawerTerminal
{

    class AOGLTerminal
    {
        public static bool _continue;
        public static SerialPort _serialPort;

        public AOGLTerminal() { }

        public void Run(string onCOM)
        {
            string message;
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            Thread readThread = new Thread(Read);
            _serialPort = new SerialPort(onCOM, 115200, Parity.None, 8, StopBits.One);
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
            _serialPort.Open();
            _continue = true;
            readThread.Start();
            Console.WriteLine("[program] połączono z " + onCOM + ", napisz `stop` aby zakończyć");

            while (_continue)
            {
                message = Console.ReadLine();
                if (stringComparer.Equals("stop", message))
                {
                    _continue = false;
                }
                else
                {
                    if(_serialPort.IsOpen) _serialPort.WriteLine(message);
                    else
                    {
                        try
                        {
                            _serialPort.Open();
                            if (_serialPort.IsOpen) { Console.WriteLine("[połączono]"); }
                            _continue = true;
                        }
                        catch (System.IO.IOException)
                        {
                            Console.WriteLine("[błąd] Brak połączenia");
                        }
                    }
                }
               
            }
            readThread.Join();
            _serialPort.Close();
        }

        public static void Read()
        {
            while (_continue)
            {
                try
                {
                    if(_serialPort.IsOpen) {
                        string message = _serialPort.ReadLine();
                        Console.WriteLine("> " + message);
                    }
                }
                catch (System.IO.IOException e)
                {
                    Console.WriteLine("[rozłączono] " + e.Message);
                    _serialPort.Close();
                } 
                catch (TimeoutException) { }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * 1. Wykryj sterownik CH341SER
             * 2. Wykryj port z podłączoną maszyna
             * 3. Komunikacja
             */

            // 1. Wykryj sterownik
            Console.Write("[program] AOGLTerminal \t");
            DriverManager dm = new DriverManager();
            if (dm.Status == DriverManager.DriverStatus.DriverFound)
            {
                Console.Write("[sterownik] OK\t");
            }
            else
            {
                Console.WriteLine("[sterownik] brak\t");
                return;
            }

            // 2. Wykryj port
            PortFinder pf = new PortFinder();
            if (pf.Status == PortFinder.PortFinderStatus.PortFound)
            {
                Console.Write(String.Format("[port] OK: {0}\t\n", pf.Get()));
            }
            else
            {
                switch (pf.Status)
                {
                    case PortFinder.PortFinderStatus.PortMatchError: { Console.WriteLine("[port] MatchError"); break; }
                    case PortFinder.PortFinderStatus.PortNotFound: { Console.WriteLine("[port] NotFound"); break; }
                    case PortFinder.PortFinderStatus.ManagementSearcherError: { Console.WriteLine("[port] MgmtSearchError"); break; }
                }
            }

            
            // 3. Komunikacja
            if (pf.Status == PortFinder.PortFinderStatus.PortFound)
            {
                AOGLTerminal term = new AOGLTerminal();
                term.Run(pf.Get());
            }

            Console.WriteLine("[end] nacisnij dowolny przycisk by wyjść");
            Console.ReadKey();
        }

        
    }
}
