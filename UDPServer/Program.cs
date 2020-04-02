using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UDPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 10000;
            UdpClient udpServer = new UdpClient(port);
            while (true)
            {
                Thread.Sleep(1000);
                var remoteEP = new IPEndPoint(IPAddress.Broadcast, port);
                udpServer.Send(new byte[] { 1 }, 1, remoteEP);

            }
        }
    }
}
