using System;
using System.Collections.Generic;
using System.Text;

namespace OrderGraphfromServerToClient
{
    public class Edge
    {
        public Node From;
        public Node To;
        public int km;

        public Edge(Node from, Node to, int km)
        {
            this.From = from;
            this.To = to;
            this.km = km;
        }

        public override string ToString()
        {
            return $"=> {To.Name} - {km} km";
        }
    }
}
