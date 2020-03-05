using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<string> cityname = new Graph<string>();


            cityname.AddToGraph(new Node<string>("Aalborg", "20"));
            cityname.AddToGraph(new Node<string>("Frederikshavn", "50"));
            cityname.AddToGraph(new Node<string>("Århus", "100"));
            cityname.AddToGraph(new Node<string>("Fredercia", "150"));
            cityname.AddToGraph(new Node<string>("Odense", "200"));
            cityname.AddToGraph(new Node<string>("Sj. Odde", "1"));
            cityname.AddToGraph(new Node<string>("København", "50"));
            cityname.AddToGraph(new Node<string>("Rønne", "5000"));
            //Adds the edges from each notes
            cityname.nodes[0].AddToEdges(cityname.nodes[0], cityname.nodes[7]);
            cityname.nodes[1].AddToEdges(cityname.nodes[1], cityname.nodes[6]);
            cityname.nodes[2].AddToEdges(cityname.nodes[2], cityname.nodes[5]);
            cityname.nodes[3].AddToEdges(cityname.nodes[3], cityname.nodes[4]);
            cityname.nodes[4].AddToEdges(cityname.nodes[4], cityname.nodes[3]);
            cityname.nodes[5].AddToEdges(cityname.nodes[5], cityname.nodes[2]);
            cityname.nodes[6].AddToEdges(cityname.nodes[6], cityname.nodes[1]);
            cityname.nodes[7].AddToEdges(cityname.nodes[7], cityname.nodes[0]);

            for (int i = 1; i < cityname.nodes.Count(); i++)
            {
                Console.WriteLine(cityname.nodes[i]);
            }


            Console.ReadLine();
        }
    }
}
