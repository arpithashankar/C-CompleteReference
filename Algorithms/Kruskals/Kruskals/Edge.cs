using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruskals
{
    class Edge
    {
        public int u;
        public int v;
        public int wt;
        public Edge(int u,int v, int wt)
        {
            this.u = u;
            this.v = v;
            this.wt = wt;
        }
    }
}
