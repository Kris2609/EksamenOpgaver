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
        List<Edge<T>> edges = new List<Edge<T>>();
        public T city;
        public T value;
        public Node(T city, T gold)
        {
            this.city = city;
            this.value = gold;
        }
        public void AddToEdges(Node<T> noteTo, Node<T> noteFrom)
        {
            Edge<T> e = new Edge<T>(this,noteTo, noteFrom);

            edges.Add(e);
        }
        public override string ToString()
        {
            string sedges = "";
            foreach (var item in edges)
            {
                sedges += item.ToString();
            }
            sedges += $" Ticket {value} Dkk";
            return sedges;
        }
    }
}
