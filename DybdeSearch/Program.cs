using Graph;
using Graphh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DybdeSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Graph
            Graph<string> graph = new Graph<string>();

            Node<string> entrance = graph.AddNode(new Node<string>("Entrance",""));
            Node<string> iceblaster = graph.AddNode(new Node<string>("Ice Blaster",""));
            Node<string> slotmachine = graph.AddNode(new Node<string>("Slot Machines", ""));
            Node<string> funhouse = graph.AddNode(new Node<string>("Funhouse", ""));
            Node<string> rocketships = graph.AddNode(new Node<string>("Rocket Ships", ""));
            Node<string> cinema = graph.AddNode(new Node<string>("3D Cinema", ""));
            Node<string> pirateship = graph.AddNode(new Node<string>("Pirate Ship", ""));
            Node<string> hotdogs = graph.AddNode(new Node<string>("Hotdogs", ""));
            Node<string> logflume = graph.AddNode(new Node<string>("Log Flume", ""));
            Node<string> bigdipper = graph.AddNode(new Node<string>("Big Dipper", ""));
            Node<string> ghosttrain = graph.AddNode(new Node<string>("Ghost Train", ""));
            Node<string> rollercoaster = graph.AddNode(new Node<string>("Rollercoaster", ""));
            Node<string> carousel = graph.AddNode(new Node<string>("Carousel", ""));
            Node<string> flyingchairs = graph.AddNode(new Node<string>("Flying Chairs", ""));

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

            Console.WriteLine("Search1");
            List<Node<string>> path = new List<Node<string>>();
            List<Node<string>> visited = new List<Node<string>>();
            if (Search1(ref path, ref visited, entrance, rollercoaster))
            {
                path.Reverse();
                foreach (var node in path)
                {
                    Console.WriteLine(node);
                }
            }
            else
            {
                Console.WriteLine("No path found");
            }

            Console.WriteLine();
            Console.WriteLine("Search2");
            path = new List<Node<string>>();
            Search2(graph, ref path, entrance, pirateship);
            foreach (var node in path)
            {
                Console.WriteLine(node);
            }
            Console.ReadLine();
        }

        static bool Search1<T>(ref List<Node<T>> path, ref List<Node<T>> visited, Node<T> current, Node<T> end)
        {
            visited.Add(current);

            if (current == end)
            {
                path.Add(current);
                return true;
            }

            foreach (var edge in current.Edges)
            {
                if (!visited.Contains(edge.End))
                {
                    if (Search1(ref path, ref visited, edge.End, end))
                    {
                        path.Add(current);
                        return true;
                    }
                }
            }

            return false;
        }

        static void Search2<T>(Graph<T> graph, ref List<Node<T>> path, Node<T> start, Node<T> end)
        {
            Stack<Edge<T>> edgesToVisit = new Stack<Edge<T>>();
            Dictionary<Node<T>, Node<T>> parentPairs = new Dictionary<Node<T>, Node<T>>();

            edgesToVisit.Push(new Edge<T>(start, start));

            while (edgesToVisit.Count > 0)
            {
                Edge<T> current = edgesToVisit.Pop();

                if (!parentPairs.ContainsKey(current.End))
                {
                    parentPairs.Add(current.End, current.Start);

                    if (current.End == end)
                        break;
                }

                foreach (var edge in current.End.Edges)
                {
                    if (!parentPairs.ContainsKey(edge.End))
                        edgesToVisit.Push(edge);
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
