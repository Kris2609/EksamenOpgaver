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
            #region quicksort string
            List<string> stringQuickList = new List<string>();
            stringQuickList.Add("Bo");
            stringQuickList.Add("Julie");
            stringQuickList.Add("Torsten");
            stringQuickList.Add("Arne");
            stringQuickList.Add("Willy");
            stringQuickList.Add("Camilla");
            stringQuickList.Add("Ida");

            Console.WriteLine("QuickSort String");

            List<string> slist = StringQuickSort(stringQuickList);
            for (int i = 0; i < stringQuickList.Count; i++)
            {
                Console.WriteLine(slist[i]);
            }
            #endregion
            #region quicksort int
            //List<int> quicklist = new List<int>();
            //quicklist.Add(5);
            //quicklist.Add(-5);
            //quicklist.Add(50);
            //quicklist.Add(20);
            //quicklist.Add(35);
            //quicklist.Add(200);
            //quicklist.Add(1);
            //quicklist.Add(-100);
            //quicklist.Add(0);
            //quicklist.Add(42);

            //Console.WriteLine("QuickSort int");
            //List<int> list = QuickSort(quicklist);
            //for (int i = 0; i < quicklist.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            #endregion
            Console.ReadLine();
        }
        #region quicksort int metoder
        //public static List<int> QuickSort(List<int> quicksortList)
        //{
        //    return QuickSort(quicksortList, 0, quicksortList.Count - 1);
        //}

        //private static List<int> QuickSort(List<int> list, int startIndex, int endIndex)
        //{
        //    if (list.Count <= 1)
        //    {
        //        return list;
        //    }

        //    int pivot = list[startIndex];

        //    List<int> tempList = new List<int>();
        //    List<int> before = new List<int>();
        //    List<int> after = new List<int>();

        //    for (int i = 1; i < list.Count; i++)
        //    {
        //        if (list[i] < pivot)
        //        {
        //            before.Add(list[i]);
        //        }
        //        else
        //        {
        //            after.Add(list[i]);
        //        }
        //    }

        //    tempList.AddRange(QuickSort(before));
        //    tempList.Add(pivot);
        //    tempList.AddRange(QuickSort(after));
        //    return tempList;
        //}
        #endregion
        #region quicksortString metoder
        public static List<string> StringQuickSort(List<string> quicksortList)
        {
            return StringQuickSort(quicksortList, 0, quicksortList.Count - 1);
        }

        private static List<string> StringQuickSort(List<string> list, int startIndex, int endIndex)
        {
            if (list.Count <= 1)
            {
                return list;
            }

            string pivot = list[startIndex];

            List<string> tempList = new List<string>();
            List<string> before = new List<string>();
            List<string> after = new List<string>();

            for (int i = 1; i < list.Count; i++)
            {
                if (string.Compare(list[i], pivot)<0)
                {
                    before.Add(list[i]);
                }
                else
                {
                    after.Add(list[i]);
                }
            }

            tempList.AddRange(StringQuickSort(before));
            tempList.Add(pivot);
            tempList.AddRange(StringQuickSort(after));
            return tempList;
        }
        #endregion
    }
}
