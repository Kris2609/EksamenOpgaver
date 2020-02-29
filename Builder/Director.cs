using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Director
    {
        private readonly Builder objbuilder;

        public Director(Builder builder)
        {
            objbuilder = builder;
        }

        public void CreateProduct()
        {
            objbuilder.SetBrand();
            objbuilder.SetColor();
            objbuilder.SetEngine();
            objbuilder.SetGps();
            objbuilder.SetModel();
            objbuilder.SetSeat();
        }
        public Product Construct()
        {
            return objbuilder.GetProduct();
        }
    }
}
