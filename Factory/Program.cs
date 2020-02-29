using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory[] myCars = new CarFactory[2];

            myCars[0] = new BMWFactory();
            myCars[1] = new ToyotaFactory();

            foreach (CarFactory factory in myCars)
            {
                Car product = factory.CreateCar();
                Console.WriteLine("Created {0}", product.GetType().Name);
                Console.ReadLine();
            }
        }
    }
}
