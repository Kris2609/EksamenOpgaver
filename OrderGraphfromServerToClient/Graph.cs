using System;
using System.Collections.Generic;
using System.Text;

namespace OrderGraphfromServerToClient
{
    [Serializable]
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
        public Graph Destinations(Graph graph)
        {
            Node Frederikshavn = new Node("Frederikshavn");
            Node Aalborg = new Node("Aalborg");
            Node Århus = new Node("Århus");
            Node Fredericia = new Node("Fredericia");
            Node Odde = new Node("Sj. Odde");
            Node Odense = new Node("Odense");
            Node København = new Node("København");
            Node Rønne = new Node("Rønne");


            Aalborg.AddEdge(Århus, 118);
            Aalborg.AddEdge(København, 222);
            Århus.AddEdge(Fredericia, 93);
            Århus.AddEdge(Odde, 72);
            Fredericia.AddEdge(Odense, 54);
            Odense.AddEdge(København, 162);
            Odde.AddEdge(København, 108);
            København.AddEdge(Rønne, 150);

            graph.AddNode(Frederikshavn);

            graph.AddNode(Århus);
            graph.AddNode(Fredericia);
            graph.AddNode(Odde);
            graph.AddNode(Odense);
            graph.AddNode(København);
            graph.AddNode(Rønne);

            Console.WriteLine(graph.ToString());

            Console.Read();
            return graph;
        }
    }
}
