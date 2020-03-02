using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberList numbers = new NumberList();
            
                        
            numbers.Add(25);
            numbers.Add(30);
            numbers.Add(250);
            numbers.Add(50);
            numbers.Add(-25);
            numbers.Add(-5);
            numbers.Add(33);
            numbers.Add(88);
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(20);

            numbers.SetStrategy(new QuickSort());
            numbers.Sort();

            numbers.SetStrategy(new Insertion());
            numbers.Sort();

            numbers.SetStrategy(new BubbleSort());
            numbers.Sort();

            Console.ReadLine();
        }
    }
}
