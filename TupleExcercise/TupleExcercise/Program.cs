using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var EmpInfo = new List<Tuple<int, string, string, DateTime>>();
            EmpInfo.Add(new Tuple<int, string, string, DateTime>(1, "charvi", "si", new DateTime(2000, 2, 23)));
            EmpInfo.Add(Tuple.Create(5, "as", "a", new DateTime(1888, 12, 2)));
            EmpInfo.Add(Tuple.Create(2, "av", "b", new DateTime(1888, 12, 2)));
            foreach (var employee in EmpInfo)
            {
                Console.WriteLine($"{employee.Item1},{employee.Item2},{employee.Item3},{employee.Item4}");
            }
            Console.WriteLine("\n after sorting");
            EmpInfo.Sort();
            foreach (var employee in EmpInfo)
            {
                Console.WriteLine($"{employee.Item1},{employee.Item2},{employee.Item3},{employee.Item4}");
            }
            Console.WriteLine("--------------");
            Console.WriteLine("descending order");

            EmpInfo.Reverse();
            foreach (var employee in EmpInfo)
            {
                Console.WriteLine($"{employee.Item1},{employee.Item2},{employee.Item3},{employee.Item4}");
            }
        }
           
    }
}
