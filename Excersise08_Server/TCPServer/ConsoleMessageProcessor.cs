using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPServer
{
    class ConsoleMessageProcessor : IMessagePorcessor
    {
        public void Process(string message)
        {
            Console.WriteLine($"{DateTime.UtcNow.ToString()}: {message}");
        }
    }
}
