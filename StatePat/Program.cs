using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePat
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(new Attack());

            for (int i = 0; i < 50; i++)
            {
                player.Action();
            }

            Console.ReadLine();
        }
    }
}
