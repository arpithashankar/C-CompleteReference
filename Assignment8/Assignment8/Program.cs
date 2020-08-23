using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Baseclass;

namespace Assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            GermanSphered details = new GermanSphered();
           // names an = new names();
            details.Name = names.pugg.ToString();
            details.BirthDate = DateTime.Now;
            details.Orgin = origin.Germany.ToString();
            details.SayHi();
            details.Eat();
            details.Drink();
            details.Sit();
            details.Gender = "female";
            details.Weight = 35.5;

            details.DisplayDogInformation();
           

        }
    }

    class Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private DateTime birthdate;

        public DateTime BirthDate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        private string origin;

        public string Orgin
        {
            get { return origin; }
            set { origin = value; }
        }

    }

    interface Idog
    {
        void Eat();
        void Drink();
        void Sit();
        void SayHi();
    }

    class GermanSphered : Animal, Idog
    {
        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }


        public void Drink()
        {
            Console.WriteLine("animal is " + Name);
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }

        public void SayHi()
        {
            Console.WriteLine($"hello {Name}");
        }

        public void Sit()
        {
            Console.WriteLine($" sit {Name}");
        }
        public void DisplayDogInformation()
        {
            Console.WriteLine($"The dog name is {Name} from {Orgin}, " +
                $"was born on {BirthDate.ToShortDateString()} " +
                $"{Name} is a {Gender} and weights {Weight} kilos  ");
        }
    }


    enum origin
    {
        india, US, Germany
    };

    enum names
    {
        pugg, gs, labra
    };


}
