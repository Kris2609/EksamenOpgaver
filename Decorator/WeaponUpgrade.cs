using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class WeaponUpgrade : UniteDecorator
    {
        public WeaponUpgrade(IUnit unit) : base(unit)
        {

        }
        public override int GetDamage()
        {
            return base.GetDamage() + 1;
        }
    }
}
