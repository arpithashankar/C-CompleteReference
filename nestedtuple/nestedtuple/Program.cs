using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedtuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var empInfo = new Tuple<int, string, string, string, string, string, string, Tuple<decimal, decimal, decimal, decimal, decimal>>
                (105, "arpitha", "", "", "", "", "", Tuple.Create(2000m, 3000m, 4000m, 5000m, 6000m));
            Console.WriteLine("empl name is "+ empInfo.Item2);
            Console.WriteLine("last 5 salaries" );
            Console.WriteLine(empInfo.Rest.Item1);
            Console.WriteLine(empInfo.Rest.Item2);
            Console.WriteLine(empInfo.Rest.Item3);
            Console.WriteLine(empInfo.Rest.Item4);
            Console.WriteLine(empInfo.Rest.Item5);

        }
    }
}
