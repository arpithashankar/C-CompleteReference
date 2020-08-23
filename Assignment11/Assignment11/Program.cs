using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {
            var PlayerList = new List<Tuple<int, string, int>>();
            Addplayer(Tuple.Create(1, "as", 34), ref PlayerList);
            Addplayer(Tuple.Create(2, "ch", 87), ref PlayerList);
            Addplayer(Tuple.Create(4,"sf", 52), ref PlayerList,1);

            removepl(1, ref PlayerList);


            foreach (var player in PlayerList)
            {
                Console.Write(player.Item1);
                Console.Write("\t"+player.Item2);
                Console.Write("\t"+player.Item3);
                Console.WriteLine("\n");

            }  

        }

        public static void  Addplayer(Tuple<int,string,int> player,ref List<Tuple<int,string,int>>list)
        {

            list.Add(player);
        }

        public static void Addplayer(Tuple<int,string,int>player,ref List<Tuple<int,string,int>>list,int index)
        {
            list.Insert(index, player);
        }

        public static void removepl(int index,ref List<Tuple<int,string,int>>list)
        {
            list.RemoveAt(index);
        }
    }
}
