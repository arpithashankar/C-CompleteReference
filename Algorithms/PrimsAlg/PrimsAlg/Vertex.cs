using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimsAlg
{
    class Vertex
    {
        public String name;
        public int status;
        public int prdecessor;
        public int length;
        public Vertex(String name)
        {
            this.name = name;
        }
    }
}
