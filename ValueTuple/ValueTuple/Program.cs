using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            //var playerinfo = ( Playerno: 5,playerName: "charvi", playergoal: 60);
            //Console.WriteLine(playerinfo.Playerno);
            //Console.WriteLine(playerinfo.playerName);
            //Console.WriteLine(playerinfo.playergoal);

            var playerinfo = new List<(int playerno, string playername, int playergoal)>();
            playerinfo.Add((5, "a", 40));
            playerinfo.Add((8, "b", 30));
            foreach (var player   in playerinfo)
            {
                Console.WriteLine($"{player.playerno},{player.playername},{player.playergoal}");
            }
        }

    }
}
