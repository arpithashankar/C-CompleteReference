using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valuetuplemethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var ronaldo = (7, "ram", 55);
            playerinfo(ronaldo);
            var messi = (2, "cha", 65);
            playerinfo(messi);

            playerinfo(playerinfo());

        }

        public static void playerinfo((int playno,string playname,int playgoal) player)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine(player.playno);
            Console.WriteLine(player.playname);
            Console.WriteLine(player.playgoal);
        }
        public static (int,string,int) playerinfo()
        {
            var vikram = (4, "av", 90);
            return vikram;
        }
    }
}
