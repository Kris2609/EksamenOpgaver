using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Insertion : IStrategy
    {
        public void Sort(int[] list)
        {
            int value;
            int pointer;
            for (int i = 1; i < list.Length; i++)
            {
                value = list[i];
                pointer = i;
                while (pointer > 0 && value < list[pointer - 1])
                {
                    list[pointer] = list[pointer - 1];
                    pointer = pointer - 1;
                }
                list[pointer] = value;
            }
        }

        public void Sort(List<int> list)
        {
            Console.WriteLine("Insertion");
        }
    }
}
