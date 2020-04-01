using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Øvelser
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Opgave1
            //string message = "Hallo World";
            //ThreadCall tc = new ThreadCall("Hallo World");
            //ThreadCall tc2 = new ThreadCall(10);
            //ThreadCall tc3 = new ThreadCall("Hallo World", 10);
            //Thread t = new Thread(tc.PrintMessage);
            //Thread t2 = new Thread(tc2.PrintNumber);
            //Thread t3 = new Thread(tc3.PrintBothNumberAndMessage);
            //Thread mes = new Thread(Objectmessage);
            //mes.Start(message);
            //t.Start();
            //t.Join();
            //t2.Start();
            //t2.Join();
            //t3.Start();
            //t3.Join();
            #endregion
            #region Opgave 2
            Thread one = new Thread(() => Metode1());
            Thread two = new Thread(() => Metode2());
            one.IsBackground = true;
            one.Start();
            two.Start();
            #endregion
        }

        #region MetoderTilOpgave1
        private static void Objectmessage(object o)
        {
            string message = (string)o;
            Console.WriteLine("This is a object message: {0}", message);
        }
        #endregion
        #region MetoderTilOpgave2
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
        #endregion
    }
}
