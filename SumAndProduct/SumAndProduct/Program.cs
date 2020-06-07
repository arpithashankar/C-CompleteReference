using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAndProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum=0;
            int Product=1;
            for (int i = 1; i <=10; i++)
            {
                Sum += i;
                Product *= i;

            }
            Console.WriteLine("Sum is " +Sum);
            Console.WriteLine("Product is "+Product);

        }
    }
}
