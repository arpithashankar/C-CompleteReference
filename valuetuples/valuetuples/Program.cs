using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valuetuples
{
    class Program
    {
        static void Main(string[] args)
        {
            //intall package "System.ValueTuple"
            //path tools nuget package manager- manage nuget packet for solution, browse valuetuple and install
            int x = 0;
            (int playerno, string playername, int playergoal) game = (2, "ram", 55);
            Console.WriteLine(game.playerno);
            Console.WriteLine(game.playername   );
            Console.WriteLine(game.playergoal);

            var messi = (10, "ch", 75);
            Console.WriteLine(messi.Item1);
            Console.WriteLine(messi.Item2);
            Console.WriteLine(messi.Item3);

            var cha = (playerno: 10, playername: "ch",playergoal: 75);
            Console.WriteLine(cha.playerno);
            Console.WriteLine(cha.playergoal);
            Console.WriteLine(cha.playername);
        }
    }
}
