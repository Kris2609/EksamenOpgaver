using Graph;
using Graphh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA03Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Graph
            
            Graph<string> graph = new Graph<string>();
            
            Node<string> entrance = graph.AddNode(new Node<string>("Århus",""));
            Node<string> Aalborg = graph.AddNode(new Node<string>("Aalborg", ""));
            Node<string> Frederikshavn = graph.AddNode(new Node<string>("Frederikshavn", ""));
            Node<string> SjOdde = graph.AddNode(new Node<string>("Sj. Odde",""));
            Node<string> Fredericia = graph.AddNode(new Node<string>("Fredericia", ""));
            Node<string> Cph = graph.AddNode(new Node<string>("København",""));
            Node<string> Ronne = graph.AddNode(new Node<string>("Rønne", ""));
            Node<string> Odense = graph.AddNode(new Node<string>("Odense",""));
          

            graph.AddEdge(entrance, Frederikshavn);
            graph.AddEdge(entrance, Aalborg);
            graph.AddEdge(entrance, SjOdde);

            graph.AddEdge(Frederikshavn, Fredericia);
            graph.AddEdge(Frederikshavn, Odense);

            graph.AddEdge(Aalborg, Frederikshavn);
            graph.AddEdge(Aalborg, Fredericia);
            graph.AddEdge(Aalborg, SjOdde);
            graph.AddEdge(Aalborg, Cph);

            graph.AddEdge(SjOdde, Cph);


            graph.AddEdge(Cph, Fredericia);
            graph.AddEdge(Cph, Ronne);
            #endregion

            List<Node<string>> path = new List<Node<string>>();
            Search(graph, ref path, entrance, Ronne);
            foreach (var node in path)
            {
                Console.WriteLine(node);
            }
            Console.ReadLine();
        }
        static void Search<T>(Graph<T> graph, ref List<Node<T>> path, Node<T> start, Node<T> end)
        {
          
            Queue<Edge<T>> edgesToVisit = new Queue<Edge<T>>();
            Dictionary<Node<T>, Node<T>> parentPairs = new Dictionary<Node<T>, Node<T>>();

            edgesToVisit.Enqueue(new Edge<T>(start, start));

            while (edgesToVisit.Count > 0)
            {
                Edge<T> currentEdge = edgesToVisit.Dequeue();

                foreach (var edge in currentEdge.End.Edges)
                {
                    if (!parentPairs.ContainsKey(edge.End))
                    {
                        edgesToVisit.Enqueue(edge);
                        parentPairs.Add(edge.End, edge.Start);

                        if (edge.End == end)
                        {
                            edgesToVisit.Clear();
                            break;
                        }
                    }
                }
            }

            path = new List<Node<T>>() { end };
            while (path.Last() != start)
            {
                path.Add(parentPairs[path.Last()]);
            }
            path.Reverse();
        }
    }
}
