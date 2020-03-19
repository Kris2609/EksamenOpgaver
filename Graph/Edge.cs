using Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphh
{
    public class Edge<T>
    {
        public Node<T> Start { get; private set; }
        public Node<T> End { get; private set; }
        public Edge(Node<T> start, Node<T> end)
        {
            Start = start;
            End = end;
        }

        public override string ToString()
        {
            return $"From {Start.Value.ToString()} To {End.Value.ToString()}";
        }

    }
}
