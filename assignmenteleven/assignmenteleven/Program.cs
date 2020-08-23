using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmenteleven
{
    class Program
    {
        static void Main(string[] args)
        {
            var playersList = new List<Tuple<int, string, int>>();
            AddPlayer(Tuple.Create(7, "Ronaldo", 55), ref playersList);
            AddPlayer(Tuple.Create(17, "Rooney", 55), ref playersList);
            AddPlayer(Tuple.Create(10, "Messi", 55), ref playersList, 0);

            RemovePlayer(1, ref playersList);

            foreach (var player in playersList)
            {
                Console.WriteLine(player.Item1);
                Console.WriteLine(player.Item2);
                Console.WriteLine(player.Item3);
                Console.WriteLine("---------");
            }
        }

        public static void AddPlayer(Tuple<int, string, int> player, ref List<Tuple<int, string, int>> list)
        {
            list.Add(player);
        }

        public static void AddPlayer(Tuple<int, string, int> player, ref List<Tuple<int, string, int>> list, int index)
        {
            list.Insert(index, player);
        }

        public static void RemovePlayer(int index, ref List<Tuple<int, string, int>> list)
        {
            list.RemoveAt(index);
        }
    
    }
}
