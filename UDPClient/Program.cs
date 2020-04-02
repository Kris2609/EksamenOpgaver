using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UDPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 10000;
            UdpClient client = new UdpClient();
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Loopback, port);
            client.Connect(iPEndPoint);

            while (true)
            {
                Console.WriteLine(client.Receive(ref iPEndPoint).ToString());

            }
        }
    }
}
