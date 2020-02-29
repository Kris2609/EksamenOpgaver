using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Smart : Builder
    {
        Product objSmart = new Product();
        public override Product GetProduct()
        {
            return objSmart;
        }

        public override void SetBrand()
        {
            objSmart.SetBrand = "Smart";
        }

        public override void SetColor()
        {
            objSmart.SetColor = "White";
        }

        public override void SetEngine()
        {
            objSmart.SetEngine = "0.6";
        }

        public override void SetGps()
        {
            objSmart.SetGps = "Gps Check";
        }

        public override void SetModel()
        {
            objSmart.SetModel = "Small Car";
        }

        public override void SetSeat()
        {
            objSmart.SetSeat = "2 Seats";
        }
    }
}
