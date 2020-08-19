using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimsAlg
{
    class UnDirectedWeighted
    {
        public readonly int Max_Vertices = 30;
        int e;
        int n;
        int[,] adj;
        Vertex[] vertexList;
        private readonly int temp = 1;
        private readonly int per = 2;
        private readonly int nil = -1;
        private readonly int infi = 99999;

        public UnDirectedWeighted()
        {
            adj = new int[Max_Vertices, Max_Vertices];
            vertexList = new Vertex[Max_Vertices];
        }

        public int  Vertices()
        {
            return n;
        }
        public int Edges()
        {
            return e;
        }

        public void Prims()
        {
            int c, v;
            int edgesInTree = 0;
            int WtTree = 0;
            for(v=0;v<n;v++)
            {
                vertexList[v].status = temp;
                vertexList[v].prdecessor = nil;
                vertexList[v].length = infi;
            }

            int root = 0;
            vertexList[root].length = 0;
            while(true)
            {
                c = TempVertexMinL();
                if(c==nil)
                {
                    if (edgesInTree == n - 1)
                    {
                        Console.WriteLine("weight of min spanning tree is " + WtTree);
                        return;
                    }
                    else
                        throw new InvalidOperationException
                            ("graph is not connected, spanning tree is not possible");
                }

                vertexList[c].status = per;
                if(c!=root)
                {
                    edgesInTree++;
                    Console.WriteLine("(" + vertexList[c].prdecessor + "," + c + " )");
                    WtTree = WtTree + adj[vertexList[c].prdecessor, c];


                }

                for (v = 0; v < n; v++)
                    if(IsAdjacent(c,v) && vertexList[v].status==temp)
                        if(adj[c,v]<vertexList[v].length)
                        {
                            vertexList[v].length = adj[c, v];
                            vertexList[v].prdecessor = c;
                        }
                


                
            }
        }

        int TempVertexMinL()
        {
            int min = infi;
            int x = nil;
            for (int v = 0; v < n; v++)
            {
                if(vertexList[v].status==temp && vertexList[v].length<min)
                {
                    min = vertexList[v].length;
                    x = v;
                }
            }
            return x;

            
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
