using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random number = new Random();
            int x=number.Next(1, 3);
            string monthname = "";
            if (x == 1)
                monthname = "jan - 31 days";
            else if (x ==2)
                monthname = "feb-28 days";
            Console.WriteLine(monthname);

                }
    }
}
