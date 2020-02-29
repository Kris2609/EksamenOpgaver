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
            int[] cardarray = new int[] { 5, 4, 3, 10, 13, 12, 11, 0 };
            Console.WriteLine("Insertion Sort");
            CardSort(cardarray);
        }
        public static void CardSort(int[] cardarray)
        {
            
            int value;
            int pointer;
            for (int i = 1; i < cardarray.Length; i++)
            {
                value = cardarray[i];
                pointer = i;
                while (pointer > 0 && value < cardarray[pointer - 1])
                {
                    cardarray[pointer] = cardarray[pointer - 1];
                    pointer = pointer - 1;
                }
                cardarray[pointer] = value;
            }
            foreach (int card in cardarray)
            {
                Console.WriteLine(card.ToString());
            }
        }
    }
}
