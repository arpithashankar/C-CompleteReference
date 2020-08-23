using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedarrayexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][,] jaggedmd = new int[3][,];
            jaggedmd[0] = new int[2,2] { { 1, 2 }, { 3, 4 } };
            jaggedmd[1] = new int[3,2] { { 1, 2 }, { 1, 3 }, { 4, 2 } };
            jaggedmd[2] = new int[3, 2] { { 5, 7 }, { 7, 2 }, { 4, 2 } };
            Console.WriteLine();
        }
    }
}
