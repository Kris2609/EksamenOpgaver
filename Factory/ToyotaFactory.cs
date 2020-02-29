using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ToyotaFactory : CarFactory
    {
        public override Car CreateCar()
        {
            return new Toyota();
        }

    }
}
