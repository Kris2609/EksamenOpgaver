using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
            static void Main(string[] args)
            {
                Director d = new Director(new Toyota());
                d.CreateProduct();
                Product p = d.Construct();
                p.ShowInfo();

                Console.WriteLine("----------------------------------------------------------------------------");

                Director t = new Director(new Smart());
                t.CreateProduct();
                Product o = t.Construct();
                o.ShowInfo();

                Console.WriteLine("----------------------------------------------------------------------------");

                Director s = new Director(new BMW());
                s.CreateProduct();
                Product ps = s.Construct();
                ps.ShowInfo();
                Console.ReadLine();

            }
    }
}
