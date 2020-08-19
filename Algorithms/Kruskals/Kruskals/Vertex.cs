using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruskals
{
    class Vertex
    {
        public String name;
       
        public int father;
        
        public Vertex(String name)
        {
            this.name = name;
        }
    }
}
