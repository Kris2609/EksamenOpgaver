using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            #region insertion int
            //int[] cardarray = new int[] { 5, 4, 3, 10, 13, 12, 11, 0 };
            //Console.WriteLine("Insertion Sort");
            //CardSort(cardarray);
            #endregion
            #region Insertion string
            foreach (var name in stringSort(new string[] { "Bo" , "Julie" , "Torsten" , "Arne" , "Willy" , "Camilla" , "Ida" }))
            {
                Console.WriteLine(name);
            }
            #endregion
            Console.ReadLine();
        }
        #region insertion int metoder
        //public static void CardSort(int[] cardarray)
        //{

        //    int value;
        //    int pointer;
        //    for (int i = 1; i < cardarray.Length; i++)
        //    {
        //        value = cardarray[i];
        //        pointer = i;
        //        while (pointer > 0 && value < cardarray[pointer - 1])
        //        {
        //            cardarray[pointer] = cardarray[pointer - 1];
        //            pointer = pointer - 1;
        //        }
        //        cardarray[pointer] = value;
        //    }
        //    foreach (int card in cardarray)
        //    {
        //        Console.WriteLine(card.ToString());
        //    }
        //}
        #endregion
        #region Insertion string metode

        public static string[] stringSort(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                string value = names[i];
                int pointer = i;

                while (pointer > 0 && string.Compare(value,names[pointer - 1])<0)
                {
                    names[pointer] = names[pointer - 1];
                    pointer = pointer - 1;
                }
                names[pointer] = value;
            }
            return names;
        }
        #endregion
    }
}
