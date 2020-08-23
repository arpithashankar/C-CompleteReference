using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_excersise
{
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes mer = new Mercedes();
            mer.DisplayInfo();

        }
    }
    //region is used to shrink or hide the code
    #region cars
    class Cars
    {
        private decimal price;
        protected int maxSpeed;
        public string color;

        protected decimal Price
        {
            get { return price; }
              set { Price = value; }
        }

        public virtual void DisplayInfo()
        {
            price = 10000;
            maxSpeed = 300;
            color = "black";
            Console.WriteLine($"Default values : price is {price}, max speed is {maxSpeed} and the color is {color}");
        }
    }

    class Mercedes : Cars
    {
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            // cannot access price because it is private, so create a property to access private
            base.Price = 20000;
            base.color = "blue";
            base.maxSpeed = 250;
            Console.WriteLine($"Default values : price is {Price}, max speed is {maxSpeed} and the color is {color}");

        }
    }
    #endregion
}
