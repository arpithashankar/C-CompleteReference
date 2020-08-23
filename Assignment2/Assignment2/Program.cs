using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int day, month;
            //int year;
            Console.WriteLine("enter the day");
            var day = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the month");
            var month = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the year");
            var year = int.Parse(Console.ReadLine());

            //DateTime weekday = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day) );

            DateTime weekday = new DateTime(year, month, day);

            Console.WriteLine(weekday.DayOfWeek);



        }
    }
}
