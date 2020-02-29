using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Tank : IUnit
    {
        public int GetArmor()
        {
            return 10;
        }

        public int GetDamage()
        {
            return 5;
        }
    }
}
