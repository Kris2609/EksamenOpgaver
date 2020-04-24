using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pa04_Algoritme
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            
            Node Frederikshavn = new Node("Frederikshavn");
            Node Aalborg = new Node("Aalborg");
            Node Århus = new Node("Århus");
            Node Fredericia = new Node("Fredericia");
            Node Odde = new Node("Sj. Odde");
            Node Odense = new Node("Odense");
            Node København = new Node("København");
            Node Rønne = new Node("Rønne");

            Frederikshavn.AddEdge(Aalborg, 64);
            Aalborg.AddEdge(Århus, 118);
            Aalborg.AddEdge(København, 222);
            Århus.AddEdge(Fredericia, 93);
            Århus.AddEdge(Odde, 72);
            Fredericia.AddEdge(Odense, 54);
            Odense.AddEdge(København, 162);
            Odde.AddEdge(København, 108);
            København.AddEdge(Rønne, 150);

            graph.AddNode(Frederikshavn);
            graph.AddNode(Aalborg);
            graph.AddNode(Århus);
            graph.AddNode(Fredericia);
            graph.AddNode(Odde);
            graph.AddNode(Odense);
            graph.AddNode(København);
            graph.AddNode(Rønne);

            Console.WriteLine(graph.ToString());
            
            Console.Read();
        }
    }
}
