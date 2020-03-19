using Graphh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Node<T>
    {
        public T Value { get; private set; }

        public List<Edge<T>> Edges { get; private set; } = new List<Edge<T>>();
        
        public Node(T value) { Value = value; }

        public void AddEdge(Node<T> end, bool addReturn = true)
        {
            Edges.Add(new Edge<T>(this, end));
            if (addReturn)
            {
                end.AddEdge(this, false);
            }
        }

        public void RemoveEdge(Node<T> end)
        {
            foreach (var edge in Edges)
            {
                if (edge.End == end)
                {
                    Edges.Remove(edge);
                    return;
                }
            }
        }
        
        public override string ToString()
        {
            return $"Node: {Value.ToString()}";
        }
    }
}
