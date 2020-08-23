using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valuetupleexcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var listofplayrs= new List<(int playrno, string palyrname, int playrgoal)>();
            listofplayrs.Add((4, "ram", 23));
            listofplayrs.Add((2, "as", 75));
            listofplayrs.Add((5, "er", 56));
            listofplayrs.Add((8, "hj", 85));

            foreach (var player in listofplayrs)

            {
                Console.WriteLine($"{player.playrno},{player.palyrname},{player.playrgoal}");
            }

            Console.WriteLine("-----------------------");
            Console.WriteLine("after sorting");
            listofplayrs.Sort();
            foreach (var player in listofplayrs)

            {
                Console.WriteLine($"{player.playrno},{player.palyrname},{player.playrgoal}");
            }




        }
    }
}
