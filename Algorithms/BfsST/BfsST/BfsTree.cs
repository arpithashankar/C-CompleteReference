using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BfsST
{
    class DirectedGraph
    {
            public readonly int MAX_VERTICES = 30;
            int n;
            int e;
            bool[,] adj;
            Vertex[] VertexList;

            private readonly int initial = 0;
            private readonly int waiting = 1;
            private readonly int visited = 2;
            //private readonly int nil = -1;
            //private readonly int infinity = 99999;

            public DirectedGraph()
            {
                adj = new bool[MAX_VERTICES, MAX_VERTICES];
                VertexList = new Vertex[MAX_VERTICES];

            }
            public void BfsTreeEdges()
            {
                int v;
                for (v = 0; v < n; v++)
                    VertexList[v].state = initial;
                Console.Write("enter starting vertex from BFS : ");
                String s = Console.ReadLine();
                BfsTree(GetIndex(s));
                for (v = 0; v < n; v++)
                    if (VertexList[v].state == initial)
                        BfsTree(v);
            }
            private void BfsTree(int v)
            {
                Queue<int> qu = new Queue<int>();
                qu.Enqueue(v);
                VertexList[v].state = waiting;

                while (qu.Count != 0)
                {
                    v = qu.Dequeue();
                    VertexList[v].state = visited;
                    for (int i = 0; i < n; i++)
                    {
                        if (IsAdjacent(v, i) && VertexList[i].state == initial)
                        {
                            qu.Enqueue(i);
                            VertexList[i].state = waiting;
                            Console.WriteLine("tree Edge : ( " + VertexList[v].name + "," + VertexList[i].name + ") ");

                        }
                    }
                }
                Console.WriteLine();

            }

            //Shortest Path

            //public void FindShortestPath(String s)
            //{
            //    for (int v = 0; v < n; v++)
            //    {
            //        VertexList[v].state = initial;
            //        VertexList[v].predacessor = nil;
            //        VertexList[v].distance = infinity;

            //    }
            //    Bfs(GetIndex(s));

            //    for (int v = 0; v < n; v++)
            //    {
            //        if (VertexList[v].distance == infinity)
            //            Console.WriteLine("no path from vertex " + s + " to vertex " + VertexList[v].name);
            //        else
            //        {
            //            Console.WriteLine("Shortest distance from vertex " + s + " to vertex " + VertexList[v].name + " is " + VertexList[v].distance);

            //            int[] path = new int[n];
            //            int count = 0;
            //            int x, y = v;
            //            while (y != nil)
            //            {
            //                count++;
            //                path[count] = y;
            //                x = VertexList[y].predacessor;
            //                y = x;
            //            }
            //            Console.WriteLine("shortest path is : ");
            //            int i;
            //            for (i = count; i > 1; i--)
            //                Console.Write(VertexList[path[i]].name + "-> ");
            //            Console.WriteLine(VertexList[path[i]].name);
            //        }
            //    }

            //} 

            public void BFSTraversal()
            {
                for (int v = 0; v < n; v++)
                    VertexList[v].state = initial;
                Console.WriteLine("enter the starting vertex for BFS");
                String s = Console.ReadLine();
                Bfs(GetIndex(s));
            }

            private void Bfs(int v)
            {
                Queue<int> qu = new Queue<int>();
                qu.Enqueue(v);
                VertexList[v].state = waiting;
                //VertexList[v].predacessor = nil;
                //VertexList[v].distance = 0;


                while (qu.Count != 0)
                {
                    v = qu.Dequeue();
                    VertexList[v].state = visited;
                    for (int i = 0; i < n; i++)
                    {
                        if (IsAdjacent(v, i) && VertexList[i].state == initial)
                        {
                            qu.Enqueue(i);
                            VertexList[i].state = waiting;
                            //VertexList[i].predacessor = v;
                            //VertexList[i].distance = VertexList[v].distance + 1;

                        }
                    }
                }
                Console.WriteLine();
            }

            public void BFSTraversalAll()
            {
                int v;
                for (v = 0; v < n; v++)
                    VertexList[v].state = initial;
                Console.WriteLine("enter the starting vertex for BFS");
                String s = Console.ReadLine();
                Bfs(GetIndex(s));
                for (v = 0; v < n; v++)
                    if (VertexList[v].state == initial)
                        Bfs(v);
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
                return (adj[u, v]);
            }
            public void InsertEdge(String s1, String s2)
            {
                int u = GetIndex(s1);
                int v = GetIndex(s2);

                if (u == v)
                    throw new System.InvalidOperationException("not a valid edge");
                if (adj[u, v])
                    Console.WriteLine("edge already present");
                else
                {
                    adj[u, v] = true;

                    e++;
                }

            }

            public void DeleteEdge(String s1, String s2)
            {
                int u = GetIndex(s1);
                int v = GetIndex(s2);

                if (adj[u, v])
                    Console.WriteLine("edge not present in the graph");
                else
                {
                    adj[u, v] = false;

                    e--;
                }
            }

            //public int Degree(String s)
            //{
            //    int u = GetIndex(s);
            //    int deg = 0;
            //    for (int v = 0; v < n; v++)
            //        if (adj[u, v])
            //            deg++;
            //    return deg;


            //}






        
    }
}
