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
        static void Main(string[] args)
        {
            StateObject so = new StateObject();

            for (int i = 0; i < 2; i++)
            {
                new Thread(() => new SampleTask().DeadLock1()).Start();
                new Thread(() => new SampleTask().DeadLock2()).Start();
            }
            Console.ReadLine();
        }
        
    }
}
