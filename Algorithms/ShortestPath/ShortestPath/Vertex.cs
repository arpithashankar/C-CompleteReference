using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    class Vertex
    {
        public String name;
        public int state;
        public int predacessor;
        public int distance;


        public Vertex(String name)
        {
            this.name = name;
        }
    }
}
