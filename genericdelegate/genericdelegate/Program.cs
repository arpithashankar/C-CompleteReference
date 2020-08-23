using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericdelegate
{
    public delegate T displayinfodel<T>(T value);
    class Program
    {
        static void Main(string[] args)
        {
            displayinfodel<int> mynum = new displayinfodel<int>(display);
            Console.WriteLine(mynum(100));

            displayinfodel<double> mynum1 = new displayinfodel<double>(display);
            Console.WriteLine(mynum1(5.3));
            displayinfodel<DateTime> date = new displayinfodel<DateTime>(display);
            Console.WriteLine(date(new DateTime(2020,03,23)));

        }

        public static T display<T>(T value)
        {
            Console.WriteLine("we are accessing to " + value.GetType().Name);
            return value;
        }
    }
}
