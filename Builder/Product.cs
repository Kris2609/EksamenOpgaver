using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Product
    {
        public string SetSeat { get; set; }
        public string SetModel { get; set; }
        public string SetEngine { get; set; }
        public string SetGps { get; set; }
        public string SetColor { get; set; }
        public string SetBrand { get; set; }

        public Product()
        {

        }

        public void ShowInfo()
        {
            Console.WriteLine("Brand: {0}", SetBrand);
            Console.WriteLine("Seat: {0}", SetSeat);
            Console.WriteLine("Model: {0}", SetModel);
            Console.WriteLine("Engine: {0}", SetEngine);
            Console.WriteLine("Gps: {0}", SetGps);
            Console.WriteLine("Color: {0}", SetColor);

        }
    }
}
