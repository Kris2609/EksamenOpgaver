using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pa04_Algoritme
{
    public class Graph
    {
        public List<Node> nodes = new List<Node>();

        public Node AddNode(Node node)
        {
            nodes.Add(node);
            return node;
        }

        public override string ToString()
        {
            string result = $"Graph: {Environment.NewLine}"; 
            foreach (var node in nodes)
            {
                result += node.ToString() + Environment.NewLine;
            }
            return result;
        }
    }
}
