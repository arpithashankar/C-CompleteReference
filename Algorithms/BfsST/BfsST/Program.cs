using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BfsST
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectedGraph g = new DirectedGraph();
            g.InsertVertex("zero");
            g.InsertVertex("one");
            g.InsertVertex("two");
            g.InsertVertex("three");
            g.InsertVertex("four");
            g.InsertVertex("five");
            g.InsertVertex("six");
            g.InsertVertex("seven");
            g.InsertVertex("eight");
            g.InsertVertex("nine");

            g.InsertEdge("zero", "one");
            g.InsertEdge("zero", "three");
            g.InsertEdge("one", "two");
            g.InsertEdge("one", "four");
            g.InsertEdge("one", "five");
            g.InsertEdge("two", "three");
            g.InsertEdge("two", "five");
            g.InsertEdge("three", "six");
            g.InsertEdge("four", "five");
            g.InsertEdge("four", "seven");
            g.InsertEdge("five", "six");
            g.InsertEdge("five", "eight");
            g.InsertEdge("six", "eight");
            g.InsertEdge("six", "nine");
            g.InsertEdge("seven", "eight");
            g.InsertEdge("eight", "nine");
            g.BfsTreeEdges();
        }
    }
}
