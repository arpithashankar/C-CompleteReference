using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedarray1 = new int[3][];
            jaggedarray1[0] = new int[5] { 0, 1, 2, 3, 4 };
            jaggedarray1[1] = new int[3] { 8, 2, 3 };
            jaggedarray1[2] = new int[4] { 4, 5, 2, 0 };

            //or
            int[][] jaggedarray2 =
            {
                new int[]{0,1},
                new int[]{9,4,7,2}
            };
            //Console.WriteLine("jaggedarray 2 is " + jaggedarray2[1][2]);
            for (int i = 0; i < jaggedarray2.Length; i++)
            {
                Console.WriteLine("now accessing elements of jaggedarray" +i);
                for (int j = 0; j < jaggedarray2[i].Length; j++)
                {
                    Console.WriteLine(jaggedarray2[i][j]);
                }
            }

        }
    }
}
