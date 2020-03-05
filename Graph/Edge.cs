using Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphh
{
    class Edge<T>
    {
        Node<T> noteFrom;
        Node<T> noteTo;
        Node<T> noteBack;
        public Edge(Node<T> noteFrom, Node<T> noteTo, Node<T> noteBack)
        {
            this.noteFrom = noteFrom;
            this.noteTo = noteTo;
            this.noteBack = noteBack;
        }

        public override string ToString()
        {
            return $"From {noteFrom.city} To {noteTo.city} and {noteBack.city} ";
        }

    }
}
