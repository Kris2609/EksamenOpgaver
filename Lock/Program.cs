using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lock
{
    class Program
    {
        public static int counter = 5;
        public static object lockObject = new object();
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                new Thread(() =>
                {
                    while (true)
                    {
                        lock (lockObject)
                        {
                            if (counter == 5)
                            {
                                counter++;
                                if (counter != 6)
                                {
                                    throw new Exception("Race Condition");
                                }
                            }
                            counter = 5;
                        }
                    }

                }).Start();
            }

            Console.ReadLine();
        }
    }
}
