using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class UniteDecorator : IUnit
    {
        private IUnit iUnite;

        public UniteDecorator(IUnit unit)
        {
            this.iUnite = unit;
        }

        public int GetArmor()
        {
            return iUnite.GetArmor();
        }

        public int GetDamage()
        {
            return iUnite.GetDamage();
        }
    }
}
