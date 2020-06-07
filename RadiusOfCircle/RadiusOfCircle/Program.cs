using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiusOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            double area;
            area=int.Parse(Console.ReadLine());
            r = Math.Sqrt(area / 3.1416);
            Console.WriteLine("the Radius is " +r);
        }
    }
}
