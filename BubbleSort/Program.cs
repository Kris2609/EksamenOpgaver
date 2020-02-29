using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bubbleSort = new int[] { 10, 0, 3, 2, 1, 2, 3, 4, 5, 7 };
            Console.WriteLine("BubbleSort");
            BubbleSorting(bubbleSort);
            for (int i = 0; i < bubbleSort.Length; i++)
            {
                Console.WriteLine(bubbleSort[i]);
            }
        }
        public static void BubbleSorting(int[] bubbleSort)
        {
            bool swapped = false;

            for (int i = 1; i < bubbleSort.Length; i++)
            {
                if (bubbleSort[i - 1] > bubbleSort[i])
                {
                    Swap(ref bubbleSort[i - 1], ref bubbleSort[i]);
                    swapped = true;
                }
            }

            if (swapped)
            {
                BubbleSorting(bubbleSort);
            }
        }
        public static void Swap<T>(ref T first, ref T second)
        {
            T tmp = first;
            first = second;
            second = tmp;
        }
    }
}
