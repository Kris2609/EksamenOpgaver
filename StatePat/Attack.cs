using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePat
{
    class Attack : State
    {
        public override void Handle(Player player)
        {
            Console.WriteLine("Attacking");
            player.hunger--;
            if (player.hunger <= 0)
            {
                player.State = new Eat();
            }
        }
    }
}
