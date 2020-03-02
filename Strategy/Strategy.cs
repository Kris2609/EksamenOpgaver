using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    interface IStrategy
    {
        void Sort(int[] list);
        void Sort(List<int> list);
    }
}
