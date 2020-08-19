using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnhancementTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<clubs> clubsinfo = new List<clubs>();
            clubsinfo.Add(clubs.Mahindra);
            clubsinfo.Add(clubs.manchester);

            List<clubs> clubsinfo1 = new List<clubs>();
            clubsinfo1.Add(clubs.Tayota);
            clubsinfo1.Add(clubs.manchester);



            var listofPlayers = new List<(int PlayerNo, string PlayerName, 
                int PlayerGoal, List<clubs> Clubs, countries country)>();
            listofPlayers.Add((3, "Amisha", 50, clubsinfo, countries.india));
            listofPlayers.Add((1, "sonali", 60, clubsinfo1, countries.germany));

            foreach (var player in listofPlayers)
            {
                Console.Write($" player no : {player.PlayerNo} \n player name : {player.PlayerName} \n" +
                    $" player goal : {player.PlayerGoal} \n country : {player.country} \n clubs:");

                foreach (var club in player.Clubs)
                {
                    Console.Write(club   + " ");
                }
                Console.WriteLine("\n____________________________________");
            }

        }

        

        enum clubs
        {
            manchester,
            Tayota,
            Mahindra,

        }
        enum countries
        {
            india,
            germany,
            unitedKingdom,

        }
    }

}
