using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = DateTime.Now.DayOfWeek.ToString();





            switch (day)

            {
                case "monday":Console.WriteLine("yellow"); break;
                case "Tuesday": Console.WriteLine("red"); break;
                case "Wednesday": Console.WriteLine("orange"); break;
                case "thursday": Console.WriteLine("white"); break;
                default:
                    break;
            }
        }

    }

    
}
