using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        private static int armyCount = 0;
        static void Main(string[] args)
        {
            
            while (armyCount < 5)
            {
                IUnit Firefighter = new Dps();
                IUnit Tanky = new Tank();
                Print(Firefighter);
                Firefighter = new WeaponUpgrade(Firefighter);
                Print(Firefighter);
                Firefighter = new WeaponUpgrade(Firefighter);
                Print(Firefighter);
                Firefighter = new ArmorUpgrade(Firefighter);
                Print(Firefighter);
                Tanky = new WeaponUpgrade(Tanky);
                Print(Tanky);
                Tanky = new ArmorUpgrade(Tanky);
                Print(Tanky);
                Tanky = new ArmorUpgrade(Tanky);
                Print(Tanky);
                armyCount++;
            }
        }

        private static void Print(IUnit unit)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Damage: " + unit.GetDamage());
            Console.WriteLine("Armor: " + unit.GetArmor());
        }
    }
}
