using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            FourWheeledVehicle car = new FourWheeledVehicle();
            car.ChangeColor();
            car.StartVehicle();
            car.RunAtFullSpeed();
        }
    }
}
