using Snowbooks_Server.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Snowbooks_Server
{
    class Program
    {

        private static long StartTick;

        static void Main(string[] args)
        {
            StartTick = DateTime.Now.Millisecond;
            StartupTask.RunSynchronously();
            Server server = new Server();
            server.Start();

            while (server.IsRunning)
            {
                Thread.Sleep(500);
            }

            Console.WriteLine("Finished Running");
            Console.ReadLine();
        }

        private static Task StartupTask = new Task(() => 
        {
            PacketHandler.InitiatePacketTypes();
            Console.WriteLine($"StartupTask took {DateTime.Now.Millisecond - StartTick}ms to finish.");
        });
    }
}
