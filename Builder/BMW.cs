using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class BMW : Builder
    {
        Product objProduct = new Product();
        public override Product GetProduct()
        {
            return objProduct;
        }

        public override void SetBrand()
        {
            objProduct.SetBrand = "BMW";
        }

        public override void SetColor()
        {
            objProduct.SetColor = "Red";
        }

        public override void SetEngine()
        {
            objProduct.SetEngine = "V12";
        }

        public override void SetGps()
        {
            objProduct.SetGps = "Gps Check";
        }

        public override void SetModel()
        {
            objProduct.SetModel = "F50";
        }

        public override void SetSeat()
        {
            objProduct.SetSeat = "2 Seats";
        }
    }
}
