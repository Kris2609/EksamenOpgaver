using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 10000;
            TcpClient client = new TcpClient("LocalHost", port);
            NetworkStream networkStream = client.GetStream();

            while (true)
            {
                byte[] sizeBytes = new byte[4];
                networkStream.Read(sizeBytes, 0, 4);

                byte[] msgt = new byte[BitConverter.ToInt32(sizeBytes, 0)];
                networkStream.Read(msgt, 0, msgt.Length);

                Console.WriteLine(Encoding.UTF8.GetString(msgt,0,msgt.Length));
            }
        }
    }
}
