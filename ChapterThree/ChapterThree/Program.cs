using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterThree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demonstrate Math.Sin(), Math.Cos(), and Math.Tan().
            Double theta;
            for (theta = 0.1; theta <= 1.0; theta = theta + 0.1)
            {
                Console.WriteLine("Sine of " + theta + " is " + Math.Sin(theta));
                Console.WriteLine("Cosine of " + theta + " is " + Math.Cos(theta));
                Console.WriteLine("Tangent of " + theta + " is " + Math.Tan(theta));
                Console.WriteLine();
            }
            Console.WriteLine("_______________________________________________________________");

            //The program computes the discounted price given the original price and a discount percentage
            decimal price;
            decimal discount;
            decimal discounted_price;
            // Compute discounted price.
            price = 19.95m;
            discount = 0.15m; // discount rate is 15%
            discounted_price = price - (price * discount);
            Console.WriteLine("Discounted price: $" + discounted_price);

            Console.WriteLine("_______________________________________________________________");

            // Use format commands.

            int i;
            Console.WriteLine("Value\tSquared\tCubed");
            for (i = 1; i < 10; i++)
                Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);

            Console.WriteLine("_______________________________________________________________");

        }
    }
}

