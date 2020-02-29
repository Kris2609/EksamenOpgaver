using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Toyota : Builder
    {
        Product objToyota = new Product();

        public override Product GetProduct()
        {
            return objToyota;
        }

        public override void SetBrand()
        {
            objToyota.SetBrand = "Toyota";
        }

        public override void SetColor()
        {
            objToyota.SetColor = "Blue";
        }

        public override void SetEngine()
        {
            objToyota.SetEngine = "1.6";
        }

        public override void SetGps()
        {
            objToyota.SetGps = "Gps Gone";
        }

        public override void SetModel()
        {
            objToyota.SetModel = "Corolla";
        }

        public override void SetSeat()
        {
            objToyota.SetSeat = "5 Seats";
        }
    }
}
