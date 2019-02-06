using Snowbooks_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Snowbooks_Server
{
    public class Server
    {
        public static Socket Socket { get; set; }

        public static readonly int Port = 43595;
        public static readonly bool Debug = true;

        public bool IsRunning { get; set; }

        public void Start()
        {
            IsRunning = true;
            Console.WriteLine($"Starting server on port {Port}...");

            serverTask.RunSynchronously();
            serverTask.ContinueWith((e) => { ShutDown(); });

            Console.WriteLine("Server is done running...");
            Console.ReadLine();
        }

        public Task serverTask = new Task(() => 
        {
            IPAddress ipAd = IPAddress.Parse("127.0.0.1");
            TcpListener serverSocket = new TcpListener(ipAd, Port);
            TcpClient clientSocket = default(TcpClient);

            serverSocket.Start();
            Console.WriteLine($"Listening for connections @ {ipAd.ToString()}");
           

            while (true)
            {
                clientSocket = serverSocket.AcceptTcpClient();

                NetworkStream networkStream = clientSocket.GetStream();
                int size = clientSocket.ReceiveBufferSize;
                byte[] incomingData = new byte[size];
                networkStream.Read(incomingData, 0, size);

                Packet packet = PacketHandler.GetPacket(incomingData);

                Console.WriteLine($"Received a {packet.PacketType} packet from {clientSocket.Client.RemoteEndPoint}");
            }

        });

        public void ShutDown()
        {
            IsRunning = false;
        }

    }
}
