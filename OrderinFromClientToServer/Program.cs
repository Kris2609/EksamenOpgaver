using System;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;

namespace OrderinFromClientToServer
{
    class Program
    {
        private static TcpListener listener;
        private static int port = 10000;
        private static NetworkStream Ns;
        private static BinaryFormatter Bf = new BinaryFormatter(); 
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
                else if (input.Equals("client"));
                {
                    Client();
                }
            }
            Console.WriteLine("/n Press any key to exit");
            Console.ReadLine();
        }

        private static void Server()
        {
            //start a tcp listener so the client can connect to the server
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();

            //-- wait for the client to connect --//
            Console.WriteLine("Server running.");
            Console.WriteLine("Waiting for client");
            Ns = listener.AcceptTcpClient().GetStream();
            Console.WriteLine("Received client." + Environment.NewLine);

            TeslaFactory teslaFactory = new TeslaFactory();
            BMWFactory bmwFactory = new BMWFactory();

            while (true)
            {
                Thread.Sleep(1000);
                //-- receive car name from client --//

                //get the size of the byte array with the car name in
                byte[] size = new byte[4];
                Ns.Read(size, 0, 4);

                //get the car name as a byte array
                byte[] bytes = new byte[BitConverter.ToInt32(size, 0)];
                Ns.Read(bytes, 0, bytes.Length);

                //turn byte array into a string
                string carName = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
                carName = carName.ToLower();
                Console.WriteLine($"Received {carName} from the client");

                //the car we are going to send
                Car car = null;

                //check what car name the user send to the server
                if (carName == "tesla")
                {
                    //build a tesla car
                    car = teslaFactory.Make();
                    Console.WriteLine($"Done building a {carName}");
                }
                else if (carName == "bmw")
                {
                    //build a bmw car
                    car = bmwFactory.Make();
                    Console.WriteLine($"Done building a {carName}");
                }
                else
                {
                    //if we dont know how to build the car set it to null
                    car = null;
                    Console.WriteLine($"Dont know how to build a {carName}");
                }

                //-- send the car to the client --//

                //if we dont know how to build the car return an empty object
                if (car == null)
                {
                    Bf.Serialize(Ns, new object());
                }
                //else send the car back
                else
                {
                    //remember to use [Serializable] on all car classes or else Serialize won't work
                    Bf.Serialize(Ns, car);
                }
            }
        }

        private static void Client()
        {

            TcpClient server = new TcpClient("localhost", port);
            Ns = server.GetStream();
            Console.WriteLine("Connected to server" + Environment.NewLine);

            while (true)
            {
                //-- get a car name from the user --//
                Console.WriteLine("Enter the car you want");
                string carName = Console.ReadLine();

                //-- send car name to server --//

                Console.WriteLine("sending car name to server" + Environment.NewLine);
                //turn car name into byte array
                byte[] bytes = Encoding.UTF8.GetBytes(carName);

                //send the size of our byte array first
                Ns.Write(BitConverter.GetBytes(bytes.Length), 0, 4);
                //send the byte array with the car name
                Ns.Write(bytes, 0, bytes.Length);


                //-- receive the car from server --//

                //we use a try-catch so if we receive something else then a car the binaryformatter will
                //throw an exception and we can then write in the console that want we got was not a car
                try
                {
                    //remember to use [Serializable] on all car classes or else Deserialize won't work
                    Car car = (Car)Bf.Deserialize(Ns);
                    Console.Clear();
                    Console.WriteLine($"Received car from the server:");
                    Console.WriteLine(car.ToString());
                }
                catch (Exception)
                {
                    Console.WriteLine($"The server could not build the car");
                }
            }
        }
    }
}
