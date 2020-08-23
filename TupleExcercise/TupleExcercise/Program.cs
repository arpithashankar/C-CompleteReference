using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tupleexcercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var empInfo = new List<Tuple<int, string, string, DateTime>>();
           // empInfo.Add(new Tuple<int, string, string, DateTime>(1, "asi", "as", new DateTime(2001,12,22)));
            //or
            empInfo.Add(Tuple.Create(9, "as", "ss", new DateTime(2014, 05, 25)));
            empInfo.Add(Tuple.Create(7, "jk", "hs", new DateTime(2016, 10, 22)));
            empInfo.Add(Tuple.Create(1, "ui", "nm", new DateTime(2004, 10, 22)));
            empInfo.Add(Tuple.Create(4, "sd", "it", new DateTime(2007, 10, 22)));

            Console.WriteLine("before sorting");
            foreach (var emp in empInfo)
            {
                Console.WriteLine($"{emp.Item1},{emp.Item2},{emp.Item3},{emp.Item4}");
               
            }

            Console.WriteLine("\n after sorting");

            empInfo.Sort();

            foreach (var emp in empInfo)
                  {
                     Console.WriteLine($"{emp.Item1},{emp.Item2},{emp.Item3},{emp.Item4}");
                     
                  }

            Console.WriteLine("\n after reverse");

            empInfo.Reverse();

            foreach (var emp in empInfo)
            {
                Console.WriteLine($"{emp.Item1},{emp.Item2},{emp.Item3},{emp.Item4}");
               
            }


        }

       
    }



}
