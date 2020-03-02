using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class NumberList
    {
        private List<int> list = new List<int>();
        private int[] List = new int[] { };
        private IStrategy strategy;

        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Add(int number)
        {
            list.Add(number);
           
        }

        public void Sort()
        {
            strategy.Sort(list);

            foreach (int number in list)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
        }
    }
}
