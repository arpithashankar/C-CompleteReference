using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuplewithmethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var charvi = Tuple.Create(11, "charvi", "ram", "a");
            dispInfo(charvi);
            var av = Tuple.Create(12, "av", "arpitha", "charvi");
            dispInfo(av);
            Console.WriteLine("------------------");
            Console.WriteLine(Getinfo().Item1);
            Console.WriteLine(Getinfo().Item2);
            Console.WriteLine(Getinfo().Item3);
            Console.WriteLine(Getinfo().Item4);
            
        }

        public static void dispInfo(Tuple<int, string, string, string> personInfo)
        {

            Console.WriteLine("---------------------");
            Console.WriteLine(personInfo.Item1);
            Console.WriteLine(personInfo.Item2);
            Console.WriteLine(personInfo.Item3);
            Console.WriteLine(personInfo.Item4);
        }
        public static Tuple<int,string,string,string> Getinfo()
        {
            var info = Tuple.Create(12, "vikram", "av", "cha");
            return info;
        }
    }
}
