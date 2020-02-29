using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Dps : IUnit
    {
        public int GetArmor()
        {
            return 5;
        }

        public int GetDamage()
        {
            return 10;
        }
    }
}
