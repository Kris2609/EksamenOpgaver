using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePat
{
    class Hide : State
    {
        public override void Handle(Player player)
        {
            Console.WriteLine("Player is hiding to attack");
            player.wait--;
            if (player.wait <= 0)
            {
                player.State = new Attack();
            }
        }
    }
}
