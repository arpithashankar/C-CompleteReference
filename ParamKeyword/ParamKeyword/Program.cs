using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
           
            DisplayName("Charvi","Arpitha","AV");
            DisplayName(7, 8, 9, 10);

        }

        public static void DisplayName<T> (params T[] Names)


        {
            foreach (var item in Names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
