using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
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

            g.InsertEdge("zero", "three", 2);
            g.InsertEdge("zero", "one",5);
          
            g.InsertEdge("zero", "four",8);
            g.InsertEdge("one", "four",2);
            g.InsertEdge("two", "one",3);
            g.InsertEdge("two", "five",4);
            g.InsertEdge("three", "four",7);
            g.InsertEdge("three", "six",8);
            g.InsertEdge("four", "five",9);
            g.InsertEdge("four", "seven",4);
            g.InsertEdge("five", "one",6);
            g.InsertEdge("six", "seven",9);
            g.InsertEdge("seven", "three",5);
            g.InsertEdge("seven", "five",3);
            g.InsertEdge("seven", "eight",5);
            g.InsertEdge("eight", "five",3);
            g.FindPaths("zero");

        }
    }
}
