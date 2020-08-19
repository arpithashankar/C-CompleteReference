using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class Vertex
    {
        public String name;
        public int status;
        public int pathLenght;
        public int predecessor;


        public Vertex(String name)
        {
            this.name = name;
        }
    }
}
