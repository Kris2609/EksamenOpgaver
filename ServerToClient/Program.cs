using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ServerToClient
{
    class Program
    {
        private static List<string> names = new List<string>
        {
            "Bo",
            "Julie",
            "Anders",
            "Camilla",
            "Torsten",
            "Ida"
        };

        private static TcpListener listener;
        private static int port = 10000;
        private static NetworkStream ns;

        static void Main(string[] args)
        {
            Console.WriteLine("Server or Client");
            while (true)
            {
                string input = Console.ReadLine().ToLower();

                if (input.Equals("server"))
                {
                    Server();
                    break;
                }
                else if (input.Equals("client"))
                {
                    Client();
                    break;
                }
            }

            Console.WriteLine(Environment.NewLine + "Press a key to exit");
            Console.Read();
        }

        static void Server()
        {
            //start a tcp listener so the client can connect to the server
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();

            //-- wait for the client to connect --//
            Console.WriteLine("Server is running");
            Console.WriteLine("Waiting for client");
            ns = listener.AcceptTcpClient().GetStream();
            Console.WriteLine($"Received client {Environment.NewLine}");

            while (true)
            {
                Thread.Sleep(1000);
                try
                {
                    //-- receive name from client --//

                    //get the size of the byte array with the name in
                    byte[] size = new byte[4];
                    ns.Read(size, 0, 4);

                    //get the name as a byte array
                    byte[] bytes = new byte[BitConverter.ToInt32(size, 0)];
                    ns.Read(bytes, 0, bytes.Length);

                    //turn byte array into a string
                    string name = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
                    Console.WriteLine($"Received {name} from the client");

                    //add the new name to our list of names and sort it
                    names.Add(name);
                    names.Sort();

                    //-- send list of names back to the client --//

                    //turn list of names into json
                    string json = JsonConvert.SerializeObject(names);
                    //turn json into byte array
                    bytes = Encoding.ASCII.GetBytes(json);

                    //send the size of our byte array first
                    ns.Write(BitConverter.GetBytes(bytes.Length), 0, 4);
                    //send the byte array with all the names
                    ns.Write(bytes, 0, bytes.Length);

                }
                catch (Exception)
                {
                    Console.WriteLine("Unable to receive name from client");
                    break;
                }
            }
        }

        private static void Client()
        {
            TcpClient server = new TcpClient("localhost", port);
            ns = server.GetStream();
            Console.WriteLine("Connected to server" + Environment.NewLine);

            while (true)
            {
                try
                {
                    //-- get a name from the user --//
                    Console.WriteLine("Enter a new name");
                    string name = Console.ReadLine();

                    //-- send name to server --//

                    Console.WriteLine("sending name to server" + Environment.NewLine);
                    //turn name into byte array
                    byte[] bytes = Encoding.ASCII.GetBytes(name);

                    //send the size of our byte array first
                    ns.Write(BitConverter.GetBytes(bytes.Length), 0, 4);
                    //send the byte array with all name
                    ns.Write(bytes, 0, bytes.Length);


                    //-- receive list of all names from server --//

                    //get the size of the byte array with the names
                    byte[] size = new byte[4];
                    ns.Read(size, 0, 4);

                    //get the names as a byte array
                    bytes = new byte[BitConverter.ToInt32(size, 0)];
                    ns.Read(bytes, 0, bytes.Length);

                    //turn byte array into a json
                    string json = Encoding.UTF8.GetString(bytes, 0, bytes.Length);

                    List<string> names = JsonConvert.DeserializeObject<List<string>>(json);

                    Console.Clear();
                    Console.WriteLine($"Received list of names from the server:");
                    foreach (var item in names)
                    {
                        Console.WriteLine($"-{item}");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Unable to send name to server");
                    break;
                }
            }
        }
    }
}
