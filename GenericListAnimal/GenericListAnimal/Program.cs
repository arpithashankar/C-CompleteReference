using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals dog = new Animals();
            dog.name = "jimmy";
            Animals cat = new Animals();
            cat.name = "buddy";
            List<Animals> details = new List<Animals>();
            details.Add(dog);
            details.Add(cat);
            foreach (var item in details)
            {
                item.SayHi();
            }
        }
    }

    class Animals
    {
        private string Name;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public void SayHi()
        {
            Console.WriteLine("hi  " + name);
        }
        public void Feed()
        {
            Console.WriteLine("hi  " + name + " is eating");
        }

    }
}
