using NDesk.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPServer
{
    //  TCP Server - vstup message. Byte[]. Procesovani na pozadi, s tim ze hodnoty budeme vypisovat do konzole serveru.
    //  Vstupni parametry budou ipAdress(127.0.0.1), port
    //  Console app - zpracovani vstupnich argumentu
    //  tcp client connect server, posila nejake zpravy - dalsi project
    //  NDESK.Options pro vstupni parametry // pkg-config --variable=Sources ndesk-options
    class Program
    {
        private static (string, int, bool) ProcessArgs(string[] args)
        {
            string ipAddress = TCPServer.DefaultIPAddress;
            string portStr = "1200";
            bool showHelp = false;

            var options = new OptionSet
            {
                { "i|ip=", $"TCP Server IP address. Default is 127.0.0.1", val => ipAddress = val },
                { "p|port", "Port, default is 1200", val => portStr = val },
                { "h|help", "show this message and exit", val => showHelp = val != null }
            };

            IList<string> extra = options.Parse(args);
            if (extra.Count > 0)
            {
                throw new ArgumentException("Illegal parameters");
            }
            if (showHelp)
            {
                ShowHelp(options);
            }
            if (!int.TryParse(portStr, out int port))
            {
                port = TCPServer.DefualtPort;
            }
            return (ipAddress, port, showHelp);
        }

        private static void ShowHelp(OptionSet optionSet)
        {
            Console.WriteLine($"Usage: {Console.Title} [OPTIONS]");
            Console.WriteLine($"{Console.Title} is tool for directory analysis.");
            Console.WriteLine("Default directory is current.");
            Console.WriteLine("Default output is console.");
            Console.WriteLine();
            Console.WriteLine("Options:");
            optionSet.WriteOptionDescriptions(Console.Out);
        }

        static void Main(string[] args)
        {
            Console.Title = "TCP Server";
            Console.WriteLine("Starting server");

            string ipAddress;
            int port;
            bool showHelp;
            
            try
            {
                (ipAddress, port, showHelp) = ProcessArgs(args);
                if (showHelp) return;
                StartTCPServer(ipAddress, port);
            }
            catch (OptionException e)
            {
                Console.WriteLine($"{Console.Title}: {e.Message}");
                Console.WriteLine($"Try '{Console.Title} --help' for more information.");
                return;
            }
        }

        private static void StartTCPServer(string ipAddress, int port)
        {
            TCPServer tcpServer = new TCPServer(new ConsoleMessageProcessor(), ipAddress, port);
            tcpServer.Listen();
        }
    }
}
