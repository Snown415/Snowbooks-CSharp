using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snowbooks_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            server.Start();

            while (server.Running)
            {
                Thread.Sleep(500);
            }

            Console.WriteLine("Finished Running");
            Console.ReadLine();
        }
    }
}
