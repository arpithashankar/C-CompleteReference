using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class DirectedGraph
    {
        public readonly int MAX_VERTICES = 30;
        int n;
        int e;
        int [,] adj;
        Vertex[] VertexList;

        private readonly int Temporary = 1;
        private readonly int Permanent=2;
        private readonly int nil = -1;
        private readonly int infinity = 99999;

        public DirectedGraph()
        {
            adj = new int[MAX_VERTICES, MAX_VERTICES];
            VertexList = new Vertex[MAX_VERTICES];

        }

        private void Dijkstra(int s)
        {
            int v, c;
            for(v=0;v<n; v++)
            {
                VertexList[v].status = Temporary;
                VertexList[v].pathLenght = infinity;
                VertexList[v].predecessor = nil;
            }
            VertexList[0].pathLenght = 0;
            while(true)
            {
                c = TempVertexMinPL();
                if (c == nil)
                    return;
                VertexList[c].status = Permanent;
                for (v = 0; v < n; v++)
                {
                    if(IsAdjacent(c,v)&&VertexList[v].status==Temporary)
                        if(VertexList[c].pathLenght +adj[c,v]<VertexList[v].pathLenght)
                        {
                            VertexList[v].predecessor = c;
                            VertexList[v].pathLenght = VertexList[c].pathLenght + adj[c, v];
                        }
                }

            }
        }

        private int TempVertexMinPL()
        {
            int min = infinity;
            int x = nil;
            for (int v = 0; v < n; v++)
            {
                if(VertexList[v].status==Temporary && VertexList[v].pathLenght<min)
                {
                    min = VertexList[v].pathLenght;
                    x = v;
                }

            }
            return x;
        }


        public void FindPaths(String source)
        {
            int s = GetIndex(source);
                Dijkstra(s);
            Console.WriteLine("source Vertex : " + source + "\n");
            for (int v = 0; v < n; v++)
            {
                Console.WriteLine("Destination Vertex : " + VertexList[v].name);
                if (VertexList[v].pathLenght == infinity)
                    Console.WriteLine("there is no path free " + source + " to vertex" + VertexList[v].name);
                else
                    FindPath(s, v);

            }
        }

        private void FindPath(int s,int v)
        {
            int i, u;
            int[] path = new int[n];
            int sd = 0;
            int count = 0;
            while (v!=s)
            {
                count++;
                path[count] = v;
                u = VertexList[v].predecessor;
                sd += adj[u, v];
                v = u;
            }
            count++;
            path[count] = s;
            Console.Write("Shortest Path is : ");
            for(i=count;i>=1;i--)
                Console.Write(path[i] + " ");
            Console.WriteLine("\n shortest distance : " + sd + " \n ");
        }    
            

        public int Vertices()
        {
            return n;
        }
        public int Edges()
        {
            return e;

        }

        public void Display()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(adj[i, j] + " ");
                Console.WriteLine();

            }

        }

        public void InsertVertex(String name)
        {
            VertexList[n++] = new Vertex(name);
        }

        private int GetIndex(String s)
        {
            for (int i = 0; i < n; i++)
                if (s.Equals(VertexList[i].name))
                    return i;
            throw new System.InvalidOperationException("invalid vertex");

        }

        public bool EdgeExists(String s1, String s2)
        {
            return IsAdjacent(GetIndex(s1), GetIndex(s2));

        }

        private bool IsAdjacent(int u, int v)
        {
            return (adj[u, v]!=0);
        }

        public void InsertEdge(String s1, String s2, int wt)
        {
            int u = GetIndex(s1);
            int v = GetIndex(s2);

            if (u == v)
                throw new System.InvalidOperationException("not a valid edge");
            if (adj[u, v]!=0)
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

            if (adj[u, v]==0)
                Console.WriteLine("edge not present in the graph");
            else
            {
                adj[u, v] = 0;

                e--;
            }
        }

    }
}
