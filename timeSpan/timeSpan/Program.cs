using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan ts = new TimeSpan(23, 65, 30);
            Console.WriteLine(ts.TotalHours);

            ts = ts.Add(new TimeSpan(0, 0, 10));
            Console.WriteLine(ts);

            DateTime date = new DateTime(2001, 12, 10);
            DateTime date2 = new DateTime(2005, 6, 20);

            TimeSpan sub = date2 - date;

            Console.WriteLine(sub);

        }
    }
}
