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
            Console.WriteLine("BulletProff Glass and MailBox Red");
            return new Toyota();
            
        }

    }
}
