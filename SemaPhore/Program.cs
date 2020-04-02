using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SemaPhore
{
    class Program
    {
        static int total = 25;
        static int done;

        static Semaphore semaPhore = new Semaphore(5, 5);
        static Random random = new Random();

        static void Main(string[] args)
        {
            for (int i = 0; i < total; i++)
            {
                new Thread(Load).Start(i);
            }
            Console.ReadLine();
        }

        public static void Load(object i)
        {
            semaPhore.WaitOne();
            Thread.Sleep(random.Next(1000, 2000));
            done++;
            UpdateUI();
            semaPhore.Release();
        }

        public static void UpdateUI()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
            Console.Write($"{done} / {total}");

            if (total == done)
            {
                Console.WriteLine();
                Console.WriteLine("Done");
            }
        }
    }
}
