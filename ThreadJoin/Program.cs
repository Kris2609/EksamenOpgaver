using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadJoin
{
    class Program
    {
        static Thread tWriteNumbers;
        static Thread tPrintNumbers;
        static List<int> numbers = new List<int>();
        static Random rnd;
        static void Main(string[] args)
        {

        }

        public static void WriteNumbers()
        {

            for (int i = 0; i < 11; i++)
            {
                numbers.Add(rnd.Next(1, 10));
                string output = "";

                foreach (var number in numbers)
                {
                    output += number + "-";
                }
                Console.WriteLine(output);
                Thread.Sleep(100);
                
            }
        }

        public static void EndProgram()
        {
            
        }
    }
}
