using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            LargestNumber l = new LargestNumber(new int[] { 20, 1, 4, 19, 21 });
            Console.WriteLine(l.FindLargestNumber());
            Console.ReadLine();
        }
    }
}
