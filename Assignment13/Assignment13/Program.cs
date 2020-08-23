using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    class Program
    {
        static void Main(string[] args)
        {
            var empinfo = new Tuple<int, int, int, int, int, int, int, Tuple<string, string, string, string, string, string, string,
                Tuple<int, int, int, int, int, int, int>>>(1, 2, 3, 4, 5, 6, 7, (" ", " ", " ", "", "", "", "", (8, 7, 6, 5, 4, 3, 2)));

        }
    }
}
