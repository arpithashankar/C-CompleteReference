using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void Playerinfo(Dictionary<int, string> players);

    class Program
    {
        
        static void Main(string[] args)
        {
            Dictionary<int, string> listofplayers = new Dictionary<int, string>();
            listofplayers.Add(5, "asi");
            listofplayers.Add(3, "av");
            Playerinfo player = new Playerinfo(displayInfo);
            player(listofplayers);
        }


        public static void displayInfo(Dictionary<int,string>players)
        {
            foreach (var item in players)
            {
                Console.WriteLine($" player no : {item.Key} , player name: {item.Value}");
            }
        }
    }
}
