using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class BubbleSort : IStrategy
    {
        public void Sort(int[] list)
        {
            bool swapped = false;
            while (true)
            {
                for (int i = 1; i < list.Length; i++)
                {
                    if (list[i - 1] > list[i])
                    {
                        Swap(ref list[i - 1], ref list[i]);
                        swapped = true;
                    }
                    swapped = false;
                }
            }
        }
        public static void Swap<T>(ref T first, ref T second)
        {
            T tmp = first;
            first = second;
            second = tmp;
        }

        public void Sort(List<int> list)
        {
            Console.WriteLine("BubbleSort");
        }
    }
}
