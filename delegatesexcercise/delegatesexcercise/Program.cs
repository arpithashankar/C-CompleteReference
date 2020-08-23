using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatesexcercise
{
    public delegate void displayplayerDel(Dictionary<int, string> player);
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> listplayer= new Dictionary<int, string>();
            listplayer.Add(7, "ram");
            listplayer.Add(2, "asi");

            displayplayerDel playerdata = new displayplayerDel(display);
            playerdata(listplayer);
           
        }

        public static void display (Dictionary<int,string> player)
        {
            foreach (var item in player)
            {
                Console.WriteLine($"player no : {item.Key}, player name : {item.Value}");
            }
            
        }
    }
}
