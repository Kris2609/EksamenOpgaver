using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpgaverTilEksamen
{
    class Program
    {
        private static object key = new object();
        private static object lockkey = new object();
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                while (true)
                {
                    lock (key)
                    {
                        lock (lockkey)
                        {
                            Console.WriteLine("1");
                        }
                    }

                }
            }).Start();

            new Thread(() =>
            {
                while (true)
                {
                    lock (lockkey)
                    {
                        lock (key)
                        {
                            Console.WriteLine("2");
                        }
                    }
                }
            }).Start();

            Console.ReadLine();
        }
        
    }
}
