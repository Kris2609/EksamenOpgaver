using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TCPServer
{
    class Program
    {
        private static TcpListener listener;
        private static int port = 10000;
        private static List<NetworkStream> clients = new List<NetworkStream>();
        private static int messageNumber = 0;
        static void Main(string[] args)
        {
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            Console.WriteLine("Server running");

            new Thread(SendMessage).Start();

            while (true)
            {
                Console.WriteLine("Waiting for a new client");
                TcpClient newTcpClient = listener.AcceptTcpClient();
                Console.WriteLine("Received clietn");

                clients.Add(newTcpClient.GetStream());
            }
        }

        static void SendMessage()
        {
            while (true)
            {
                Thread.Sleep(1000);
                messageNumber++;
                string msg = $"Hej med dig {messageNumber}";
                foreach (var client in clients)
                {
                    try
                    {
                        byte[] bytes = Encoding.ASCII.GetBytes(msg);
                        client.Write(BitConverter.GetBytes(bytes.Length), 0, 4);
                        client.Write(bytes, 0, bytes.Length);
                    }
                    catch
                    {

                        
                    }
                }
            }
        }
    }
}
