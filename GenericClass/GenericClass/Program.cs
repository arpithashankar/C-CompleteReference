using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Buildings<int> abc = new Buildings<int>();
            abc.Name = "empire state";
            abc.Height = 23;
            abc.Weight = 43;
            abc.City = "NY";
            Console.WriteLine(" name = " + abc.Name);
            Console.WriteLine("height = "+ abc.Height);
            Console.WriteLine("weight = " + abc.Weight);
            Console.WriteLine("city = " + abc.City);

            Buildings<double> xyz = new Buildings<double>();
            xyz.Name = "tower";
            xyz.Height = 43;
            xyz.Weight = 12;
            xyz.City = "dubai";
            Console.WriteLine("----------------------");
            Console.WriteLine(" name = " + xyz.Name);
            Console.WriteLine("height = " + xyz.Height);
            Console.WriteLine("weight = " + xyz.Weight);
            Console.WriteLine("city = " + xyz.City);


            Buildings<float> pqr = new Buildings<float>();
            pqr.Name = "eiffel tower";
            pqr.Height = 76;
            pqr.Weight = 52;
            pqr.City = " paris";
            Console.WriteLine("----------------------");
            Console.WriteLine(" name = " + pqr.Name);
            Console.WriteLine("height = " + pqr.Height);
            Console.WriteLine("weight = " + pqr.Weight);
            Console.WriteLine("city = " + pqr.City);



        }
    }

    class Buildings<T>
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private T height;               

        public T Height
        {
            get { return height; }
            set { height = value; }
        }

        private T weight;

        public T Weight
        {
            get { return weight; }
            set { weight = value; }
        }




    }
}
