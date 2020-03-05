using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreddeSearch
{
    class Node<T>
    {
        List<T> Visited = new List<T>();
        List<T> Current = new List<T>();
        List<T> End = new List<T>();
    }
}
