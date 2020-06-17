using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLargestNumber
{
    public class LargestNumber
    {
        private int[] numbers;

        public int[] Numbers
        {
            get { return numbers; }
        }

        public LargestNumber(int[] arr)
        {
            numbers = arr;
        }

        /// <summary>
        /// Finder den største værdi en et array
        /// </summary>
        /// <returns>Returnere det element som har størst værdi</returns>
        public int FindLargestNumber()
        {
            if (numbers.Length == 0)
                return 0;

            int largestNumber = numbers[0];

            foreach (int item in numbers)
            {
                if (largestNumber <= item)
                    largestNumber = item;
            }
            return largestNumber;
        }

        public int GetAge(int age)
        {
            if (age < 0)
            {
                throw new Exception();
            }
            return age;
        }

    }
}
