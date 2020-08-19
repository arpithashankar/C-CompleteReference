using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruskals
{
    class Program
    {
        static void Main(string[] args)
        {

            UndirectedWeighted g = new UndirectedWeighted();
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

            g.InsertEdge("zero", "one", 19);
            g.InsertEdge("zero", "three", 14);
            g.InsertEdge("zero", "four", 12);
            g.InsertEdge("one", "two", 20);
            g.InsertEdge("one", "four", 18);
            g.InsertEdge("two", "four", 17);
            g.InsertEdge("two", "five", 15);
            g.InsertEdge("two", "nine", 29);
            g.InsertEdge("three", "four", 13);
            g.InsertEdge("three", "six", 28);
            g.InsertEdge("four", "five", 16);
            g.InsertEdge("four", "six", 21);
            g.InsertEdge("four", "seven", 22);
            g.InsertEdge("four", "eight", 24);
            g.InsertEdge("five", "eight", 26);

            g.InsertEdge("five", "nine", 27);
            g.InsertEdge("six", "seven", 23);

            g.InsertEdge("seven", "eight", 30);
            g.InsertEdge("eight", "nine", 35);
            g.Kruskals();
        }
    }
}
