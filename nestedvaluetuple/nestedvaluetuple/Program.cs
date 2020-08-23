using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedvaluetuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var ronaldgoals = (year2017: 55, year2018: 50, year2019: 45);
            var ronald = (playno:2,  playname:"asi", playgoals:ronaldgoals);
            Console.WriteLine(ronald.playname);
            Console.WriteLine(ronald.playno);
            Console.WriteLine(ronald.playgoals.year2017);
        }
    }
}
