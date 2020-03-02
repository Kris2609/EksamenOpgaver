using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePat
{
    abstract class State
    {
        public abstract void Handle(Player context);
    }
}
