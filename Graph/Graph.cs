using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Graph<T>
    {
        public List<Node<T>> Nodes
        {
            get; private set;
        } = new List<Node<T>>();

        public Node<T> GetNodeByValue(T value)
        {
            return Nodes.FirstOrDefault(o => o.Value.Equals(value));
        }

        public Node<T> AddNode(Node<T> node)
        {
            if (!Nodes.Contains(node))
            {
                Nodes.Add(node);
                return node;
            }
            else
            {
                throw new Exception("Node already part of graph");
            }
        }

        public void RemoveNode(Node<T> nodeToRemove)
        {
            if (Nodes.Contains(nodeToRemove))
            {
                Nodes.Remove(nodeToRemove);
                foreach (var node in Nodes)
                {
                    node.RemoveEdge(nodeToRemove);
                }
            }
            else
            {
                throw new Exception("Node is not part of the graph");
            }
        }

        public void AddEdge(Node<T> start, Node<T> end)
        {
            start.AddEdge(end);
        }

        public void RemoveEdge(Node<T> start, Node<T> end)
        {
            if (Nodes.Contains(start))
            {
                start.RemoveEdge(end);
            }
            else
            {
                throw new Exception("Start node is not part of graph");
            }
        }

    }
}
