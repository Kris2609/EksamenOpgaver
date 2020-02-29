using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> quicklist = new List<int>();
            quicklist.Add(5);
            quicklist.Add(-5);
            quicklist.Add(50);
            quicklist.Add(20);
            quicklist.Add(35);
            quicklist.Add(200);
            quicklist.Add(1);
            quicklist.Add(-100);
            quicklist.Add(0);
            quicklist.Add(42);

            Console.WriteLine("QuickSort");
            List<int> list = QuickSort(quicklist);
            for (int i = 0; i < quicklist.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        public static List<int> QuickSort(List<int> quicksortList)
        {
            return QuickSort(quicksortList, 0, quicksortList.Count - 1);
        }

        private static List<int> QuickSort(List<int> list, int startIndex, int endIndex)
        {
            if (list.Count <= 1)
            {
                return list;
            }

            int pivot = list[startIndex];

            List<int> tempList = new List<int>();
            List<int> before = new List<int>();
            List<int> after = new List<int>();

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < pivot)
                {
                    before.Add(list[i]);
                }
                else
                {
                    after.Add(list[i]);
                }
            }

            tempList.AddRange(QuickSort(before));
            tempList.Add(pivot);
            tempList.AddRange(QuickSort(after));
            return tempList;
        }
    }
}
