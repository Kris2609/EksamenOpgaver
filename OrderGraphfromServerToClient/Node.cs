using System;
using System.Collections.Generic;
using System.Text;

namespace OrderGraphfromServerToClient
{
    [Serializable]
    public class Node
    {

        public string Name
        {
            get;
            private set;
        }

        public List<Edge> edges = new List<Edge>();

        public Node(string name)
        {
            Name = name;
        }

        public void AddEdge(Node target, int km)
        {
            edges.Add(new Edge(this, target, km));
            target.edges.Add(new Edge(target, this, km));
        }

        public override string ToString()
        {
            string result = $"Name: {Name} {Environment.NewLine}";
            foreach (var edge in edges)
            {
                result += edge.ToString() + Environment.NewLine;
            }
            return result;
        }
    }
}
