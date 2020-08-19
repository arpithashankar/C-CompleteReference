using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruskals
{
    class UndirectedWeighted
    {

        public readonly int Max_Vertices = 30;
        int e;
        int n;
        int[,] adj;
        Vertex[] vertexList;
        
        private readonly int nil = -1;
        

        public UndirectedWeighted()
        {
            adj = new int[Max_Vertices, Max_Vertices];
            vertexList = new Vertex[Max_Vertices];
        }

        public int Vertices()
        {
            return n;
        }
        public int Edges()
        {
            return e;
        }

        public void Kruskals()
        {
            PriortyQueue pq = new PriortyQueue();
            int u, v;
            for (u = 0; u < n; u++)
                for (v = 0; v < u; v++)
                {
                    if (adj[u, v] != 0)
                        pq.Insert(new Edge(u, v, adj[u, v]));
                }
            for (v = 0; v < n; v++)
                vertexList[v].father = nil;

            int v1, v2, r1 = nil, r2 = nil;
            int edgesinTree = 0;
            int wtTree = 0;

            while (!pq.IsEmpty() && edgesinTree < n - 1)
            {
                Edge edge = pq.Delete();
                v1 = edge.u;
                v2 = edge.v;
                v = v1;
                while (vertexList[v].father != nil)
                    v = vertexList[v].father;
                r1 = v;

                v = v2;
                while (vertexList[v].father != nil)
                    v = vertexList[v].father;
                r2 = v;


                if (r1 != r2)
                {
                    edgesinTree++;
                    Console.WriteLine(vertexList[v1].name + "->" + vertexList[v2].name);
                    wtTree += edge.wt;
                    vertexList[r2].father = r1;
                }
            }

            if (edgesinTree < n - 1)
                throw new InvalidOperationException
                    ("graph is not connected, spanning tree is not possible\n");
            Console.WriteLine("weight of MSP is " + wtTree);

        
            
        }

       
        

        public void InsertVertex(String name)
        {
            vertexList[n++] = new Vertex(name);
        }

        private int GetIndex(String s)
        {
            for (int i = 0; i < n; i++)
                if (s.Equals(vertexList[i].name))
                    return i;
            throw new System.InvalidOperationException("invalid vertex");

        }

        public bool EdgeExists(String s1, String s2)
        {
            return IsAdjacent(GetIndex(s1), GetIndex(s2));

        }

        private bool IsAdjacent(int u, int v)
        {
            return (adj[u, v] != 0);
        }

        public void InsertEdge(String s1, String s2, int wt)
        {
            int u = GetIndex(s1);
            int v = GetIndex(s2);

            if (u == v)
                throw new System.InvalidOperationException("not a valid edge");
            if (adj[u, v] != 0)
                Console.WriteLine("edge already present");
            else
            {
                adj[u, v] = wt;

                e++;
            }

        }

        public void DeleteEdge(String s1, String s2, int wt)
        {
            int u = GetIndex(s1);
            int v = GetIndex(s2);

            if (adj[u, v] == 0)
                Console.WriteLine("edge not present in the graph");
            else
            {
                adj[u, v] = 0;

                e--;
            }
        }
    }
}
