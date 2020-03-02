using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class QuickSort : IStrategy
    {
        public void Sort(int[] list)
        {
            
        }

        public void Sort(List<int> list)
        {
            list.Sort();
            Console.WriteLine("QuickSort");
        }
    }
}
