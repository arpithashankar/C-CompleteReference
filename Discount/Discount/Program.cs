using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//// Use the decimal type to compute a discount
namespace Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal price, discount, discounted_Price;
            Console.WriteLine("enter the price and discount");
            price = decimal.Parse(Console.ReadLine());
            discount = decimal.Parse(Console.ReadLine());
            discounted_Price = price - (price * discount);
            Console.WriteLine("the discount is " + discounted_Price);
     
        }
    }
}
