using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mutex
{
    class Program
    {
        static void Main(string[] args)
        {
            StateObject stateObject = new StateObject();

            for (int i = 0; i < 2; i++)
            {
                string name = i.ToString();
                new Thread(() => Race(stateObject, name)).Start();
            }
            Console.ReadLine();
        }

        static void Race(StateObject stateObject, string name)
        {
            Mutex mutex = new Mutex(false, "Race", out bool mutexIsNew);

            int i = 0;
            while (true)
            {
                if (mutex.WaitOne())
                {
                    try
                    {
                        stateObject.ChangeState(i++);
                    }
                    finally
                    {
                        Console.WriteLine(name);
                        mutex.ReleaseMutex();
                    }
                }
                

            }
        }
    }

    public class StateObject
    {
        private int state = 5;

        public void ChangeState(int loop)
        {
            if (state == 5)
            {
                state++;
                Trace.Assert(state == 6, "Race Conditionn. i: ", loop.ToString());
            }
            state = 5;
        }
    }
}
