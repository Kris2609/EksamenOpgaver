using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExecise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hallo World";
            ThreadCall tc = new ThreadCall("Hallo World");
            ThreadCall tc2 = new ThreadCall(10);
            ThreadCall tc3 = new ThreadCall("Hallo World", 10);
            Thread t = new Thread(tc.PrintMessage);
            Thread t2 = new Thread(tc2.PrintNumber);
            Thread t3 = new Thread(tc3.PrintBothNumberAndMessage);
            Thread mes = new Thread(Objectmessage);
            mes.Start(message);
            t.Start();
            t.Join();
            t2.Start();
            t2.Join();
            t3.Start();
            t3.Join();
        }
        private static void Objectmessage(object o)
        {
            string message = (string)o;
            Console.WriteLine("This is a object message: {0}", message);
        }
    }
}
