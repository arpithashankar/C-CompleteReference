using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance1
{
    class Vehicle
    {
        public string VehicleType;
    }
    class WheeledVehicles:Vehicle
    {
        private string color;
        private decimal price;

        public string Color { get; set; }
        public string Price { get; set; }

        public void ChangeColor()
        {
            Console.WriteLine("color is changing \n color is changed");
        }

    }
    class FourWheeledVehicle:WheeledVehicles
        
    {
        private string brandname;
        private int capacity;

        public string BrandName { get; set; }
        public string Capacity { get; set; }

        public void StartVehicle()
        {
            Console.WriteLine("car has started");
        }
        public void RunAtFullSpeed()
        {
            Console.WriteLine("car is running on full speed");
        }

        public FourWheeledVehicle()
        {

        }

    }
}
