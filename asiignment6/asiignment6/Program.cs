using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asiignment6
{
    class Program
    {
      

        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Roll dice ? (yes,no)");
            string dice = Console.ReadLine();
            if(dice.ToLower()=="yes")
            {
                int x=rand.Next(1, 7);
                Console.WriteLine("New dice no is " + x);
            }
            else
                Console.WriteLine("error");

        }
    }
}
