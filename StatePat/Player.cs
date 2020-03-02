using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePat
{
    class Player
    {
        public State State { get; set; }

        public int hunger = 10;
        public int wait = 10;

        public Player(State state)
        {
            this.State = state;
        }

        public void Action()
        {
            State.Handle(this);
        }
    }
}
