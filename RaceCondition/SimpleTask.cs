using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceCondition
{
    class SimpleTask
    {
        public void RaceCondition(StateObject state)
        {
            int i = 0;

            while (true)
            {
                state.ChangeState(i++);
            }
        }
    }
}
