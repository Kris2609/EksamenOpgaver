using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Graph<T>
    {
        public List<Node<T>> nodes = new List<Node<T>>();

        public Graph()
        {

        }

        public void AddToGraph(Node<T> node)
        {
            nodes.Add(node);

        }



    }
}
