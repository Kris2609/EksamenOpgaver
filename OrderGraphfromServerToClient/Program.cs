using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;

namespace OrderGraphfromServerToClient
{
    class Program
    {
        private static TcpListener listener;
        private static int port = 10000;
        private static NetworkStream networkStream;
        private static BinaryFormatter binaryFormatter = new BinaryFormatter();
        static void Main(string[] args)
        {
            Console.WriteLine("Are you client or server?");

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
                }
            }
            Console.WriteLine("/n Press any key to exit");
            Console.ReadLine();
        }

        public static void Server()
        {
            //start a tcp listener so the client can connect to the server
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();

            //-- wait for the client to connect --//
            Console.WriteLine("Server running.");
            Console.WriteLine("Waiting for client");
            networkStream = listener.AcceptTcpClient().GetStream();
            Console.WriteLine("Received client." + Environment.NewLine);
            Graph graph = new Graph();
            ListOfDestinations(graph);
            while (true)
            {
                Thread.Sleep(1000);

                byte[] size = new byte[4];
                networkStream.Read(size, 0, 4);


                byte[] bytes = new byte[BitConverter.ToInt32(size, 0)];
                networkStream.Read(bytes, 0, bytes.Length);

                //turn byte array into a string
                string cityName = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
                cityName = cityName.ToLower();
                Console.WriteLine($"Received {cityName} from the client");
                if (cityName == "list")
                {
                    Node Frederikshavn = new Node("Frederikshavn");
                    Node Aalborg = new Node("Aalborg");
                    Node Århus = new Node("Århus");
                    Node Fredericia = new Node("Fredericia");
                    Node Odde = new Node("Sj. Odde");
                    Node Odense = new Node("Odense");
                    Node København = new Node("København");
                    Node Rønne = new Node("Rønne");


                    Aalborg.AddEdge(Århus, 118);
                    Aalborg.AddEdge(København, 222);
                    Århus.AddEdge(Fredericia, 93);
                    Århus.AddEdge(Odde, 72);
                    Fredericia.AddEdge(Odense, 54);
                    Odense.AddEdge(København, 162);
                    Odde.AddEdge(København, 108);
                    København.AddEdge(Rønne, 150);

                    graph.AddNode(Frederikshavn);

                    graph.AddNode(Århus);
                    graph.AddNode(Fredericia);
                    graph.AddNode(Odde);
                    graph.AddNode(Odense);
                    graph.AddNode(København);
                    graph.AddNode(Rønne);

                    Console.WriteLine(graph.ToString());

                    Console.Read();
                }
            }
        }

        private static void ListOfDestinations(Graph graph)
        {
            Node Frederikshavn = new Node("Frederikshavn");
            Node Aalborg = new Node("Aalborg");
            Node Århus = new Node("Århus");
            Node Fredericia = new Node("Fredericia");
            Node Odde = new Node("Sj. Odde");
            Node Odense = new Node("Odense");
            Node København = new Node("København");
            Node Rønne = new Node("Rønne");


            Aalborg.AddEdge(Århus, 118);
            Aalborg.AddEdge(København, 222);
            Århus.AddEdge(Fredericia, 93);
            Århus.AddEdge(Odde, 72);
            Fredericia.AddEdge(Odense, 54);
            Odense.AddEdge(København, 162);
            Odde.AddEdge(København, 108);
            København.AddEdge(Rønne, 150);

            graph.AddNode(Frederikshavn);

            graph.AddNode(Århus);
            graph.AddNode(Fredericia);
            graph.AddNode(Odde);
            graph.AddNode(Odense);
            graph.AddNode(København);
            graph.AddNode(Rønne);

            Console.WriteLine(graph.ToString());

            Console.Read();
        }

        public static void Client()
        {
            TcpClient server = new TcpClient("localhost", port);
            networkStream = server.GetStream();
            Console.WriteLine("Connected to server" + Environment.NewLine);
            while (true)
            {
                //-- get a car name from the user --//
                Console.WriteLine("enter list to see all destinations");
                string cityName = Console.ReadLine();

                //-- send car name to server --//

                Console.WriteLine("sending to server" + Environment.NewLine);
                //turn car name into byte array
                byte[] bytes = Encoding.UTF8.GetBytes(cityName);

                //send the size of our byte array first
                networkStream.Write(BitConverter.GetBytes(bytes.Length), 0, 4);
                //send the byte array with the car name
                networkStream.Write(bytes, 0, bytes.Length);


                //-- receive the car from server --//

                //we use a try-catch so if we receive something else then a car the binaryformatter will
                //throw an exception and we can then write in the console that want we got was not a car
                
            }

        }
    }
}
