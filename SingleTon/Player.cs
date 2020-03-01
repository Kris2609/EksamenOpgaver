using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    class Player
    {
        private static Player instance = null;

        public static Player Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Player();
                }
                return instance;
            }
        }

        public void Print()
        {
            Console.WriteLine("I am a singleplayer");
            Console.ReadLine();
        }
    }
}
