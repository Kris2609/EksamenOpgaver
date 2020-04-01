using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExecise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread one = new Thread(() => Metode1());
            Thread two = new Thread(() => Metode2());
            one.IsBackground = true;
            one.Start();
            two.Start();
        }

        public static void Metode1()
        {
            while (true)
            {
                Console.WriteLine("I am annoying");
                Thread.Sleep(100);
            }
        }

        public static void Metode2()
        {
            int number = 0;
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
                number++;
                Thread.Sleep(100);
            }
        }
    }
}
