using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePat
{
    class Eat : State
    {
        public override void Handle(Player player)
        {
            Console.WriteLine("Resting with a burger");
            player.hunger++;
            if (player.hunger>= 10)
            {
                player.State = new Hide();
            }
        }
    }
}
