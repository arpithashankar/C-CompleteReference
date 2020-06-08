using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Future_value
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amount,rate_of_Return;
            int i, Years;
            amount = 1000.0M;
            rate_of_Return = 0.07M;
            Years = 10;
            Console.WriteLine("Original investment: $" + amount);
            Console.WriteLine("Rate of return: " + rate_of_Return);
            Console.WriteLine("Over " + Years + " years");
            for (i = 0; i < Years; i++)
            {
                amount = amount + (amount * rate_of_Return);

            }
            Console.WriteLine("Future value is $" + amount);
        }
    }
}
