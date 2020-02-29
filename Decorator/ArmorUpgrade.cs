using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ArmorUpgrade : UniteDecorator
    {
        public ArmorUpgrade(IUnit unit) : base (unit)
        {

        }
public int GetArmor()
        {
            return base.GetArmor() + 5;
        }

        
    }
}
