using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaverTilEksamen
{
    class SampleTask
    {
        private StateObject s1;
        private StateObject s2;

        public SampleTask(StateObject s1, StateObject s2)
        {
            this.s1 = s1;
            this.s2 = s2;
        }

        public void DeadLock1()
        {
            int i = 0;

            while (true)
            {
                lock (s1)
                {
                    lock (s2)
                    {
                        s1.ChangeState(i);
                        s2.ChangeState(i++);
                        Console.WriteLine("Still running {0}", i);
                    }
                }

            }
        }
        public void DeadLock2()
        {
            int i = 0;

            while (true)
            {
                lock (s2)
                {
                    lock (s1)
                    {
                        s1.ChangeState(i);
                        s2.ChangeState(i++);
                        Console.WriteLine("Still ruinning {0}", i);
                    }
                }

            }
        }
    }
}
