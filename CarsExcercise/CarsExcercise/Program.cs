using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes mer = new Mercedes();
            mer.displayInfo();
            
       
        }
    }
    #region car
    class Car
    {
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        
        public string color;
        protected int maxSpeed;
        
        

        public virtual void displayInfo()
        {
            Price = 20000;
            color = "blue";
            maxSpeed = 150;
            Console.WriteLine($" Default values :price is {Price} , and color is {color}, and max speed is {maxSpeed}");

        }
    }
    class Mercedes : Car
    {
        

        public override void displayInfo()
        {
            base.displayInfo();
            base.color = "red";
            base.maxSpeed = 100;
            base.Price = 15000m;


            Console.WriteLine($" overriden Values : price is {Price} , and color is {color}, and max speed is {maxSpeed}");
        }
    }
    #endregion
}
