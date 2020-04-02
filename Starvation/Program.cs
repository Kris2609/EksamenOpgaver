using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Starvation
{
    class Program
    {
        private static object lockobject = new object();
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                lock (lockobject)
                {
                    while (true)
                    {
                        Console.WriteLine(1);
                    }
                }
            }).Start();

            new Thread(() =>
            {
                lock (lockobject)
                {
                    while (true)
                    {
                        Console.WriteLine(2);
                    }
                }
            }).Start();

            Console.ReadLine();
        }

    }
}
