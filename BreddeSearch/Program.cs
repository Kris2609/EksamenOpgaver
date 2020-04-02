using Graph;
using Graphh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreddeSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Graph
            
            Graph<string> graph = new Graph<string>();

            Node<string> entrance = graph.AddNode(new Node<string>("Entrance"));
            Node<string> iceblaster = graph.AddNode(new Node<string>("Ice Blaster"));
            Node<string> slotmachine = graph.AddNode(new Node<string>("Slot Machines"));
            Node<string> funhouse = graph.AddNode(new Node<string>("Funhouse"));
            Node<string> rocketships = graph.AddNode(new Node<string>("Rocket Ships"));
            Node<string> cinema = graph.AddNode(new Node<string>("3D Cinema"));
            Node<string> pirateship = graph.AddNode(new Node<string>("Pirate Ship"));
            Node<string> hotdogs = graph.AddNode(new Node<string>("Hotdogs"));
            Node<string> logflume = graph.AddNode(new Node<string>("Log Flume"));
            Node<string> bigdipper = graph.AddNode(new Node<string>("Big Dipper"));
            Node<string> ghosttrain = graph.AddNode(new Node<string>("Ghost Train"));
            Node<string> rollercoaster = graph.AddNode(new Node<string>("Rollercoaster"));
            Node<string> carousel = graph.AddNode(new Node<string>("Carousel"));
            Node<string> flyingchairs = graph.AddNode(new Node<string>("Flying Chairs"));

            graph.AddEdge(entrance, slotmachine);
            graph.AddEdge(entrance, iceblaster);
            graph.AddEdge(entrance, funhouse);

            graph.AddEdge(slotmachine, rocketships);
            graph.AddEdge(slotmachine, hotdogs);

            graph.AddEdge(iceblaster, slotmachine);
            graph.AddEdge(iceblaster, rocketships);
            graph.AddEdge(iceblaster, funhouse);
            graph.AddEdge(iceblaster, cinema);

            graph.AddEdge(funhouse, cinema);

            graph.AddEdge(hotdogs, logflume);

            graph.AddEdge(logflume, bigdipper);

            graph.AddEdge(bigdipper, rollercoaster);
            graph.AddEdge(bigdipper, ghosttrain);

            graph.AddEdge(ghosttrain, carousel);
            graph.AddEdge(ghosttrain, flyingchairs);
            graph.AddEdge(ghosttrain, rocketships);

            graph.AddEdge(carousel, flyingchairs);

            graph.AddEdge(cinema, rocketships);
            graph.AddEdge(cinema, pirateship);
            #endregion

            List<Node<string>> path = new List<Node<string>>();
            Search(graph, ref path, entrance, rollercoaster);
            foreach (var node in path)
            {
                Console.WriteLine(node);
            }
            Console.ReadLine();
        }

        static void Search<T>(Graph<T> graph, ref List<Node<T>> path, Node<T> start, Node<T> end)
        {
            Queue<Ed ge<T>> edgesToVisit = new Queue<Edge<T>>();
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
