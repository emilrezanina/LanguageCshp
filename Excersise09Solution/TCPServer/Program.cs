using NDesk.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPServer
{
    class Program
    {
        static (string, int, bool) ProcessArgs(string[] args)
        {
            string ipAddress = TCPServer.DefaultIpAddress;
            string portStr = TCPServer.DefaultPort.ToString();
            bool showHelp = false;

            var options = new OptionSet
            {
                {"i|ipadress", $"TCP Server IP Adress. Default is {TCPServer.DefaultIpAddress}", val => ipAddress = val },
                {"p|port", $"TCP Server Port. Default is {TCPServer.DefaultPort}", val => portStr = val },
                { "h|help", "show this message and exit", val => showHelp = val != null }
            };

            IList<string> extra = options.Parse(args);
            if (extra.Count > 0)
                throw new ArgumentException("Illegal parameters");

            if (showHelp)
                ShowHelp(options);

            if (!int.TryParse(portStr, out int port))
                port = TCPServer.DefaultPort;
            return (ipAddress, port, showHelp);

        }

        private static void ShowHelp(OptionSet optionSet)
        {
            Console.WriteLine($"Usage: {Console.Title} [OPTIONS]");
            Console.WriteLine($"{Console.Title} is TCP Server on processing messages.");
            Console.WriteLine();
            Console.WriteLine("Options:");
            optionSet.WriteOptionDescriptions(Console.Out);
        }

        static void Main(string[] args)
        {
            Console.Title = "TCP Server";
            Console.WriteLine("Starting TCP server");

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
            TCPServer server = new TCPServer(new ConsoleMessageProcessor(), ipAddress, port);
            server.Listen();
        }
    }
}
