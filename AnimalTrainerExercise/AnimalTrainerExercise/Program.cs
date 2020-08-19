using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AnimalTrainerExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals dog = new Animals();
            dog.name = "gunda";
            Animals cat = new Animals();
            cat.name = "bangari";
            Animals elephant = new Animals();
            elephant.name = "lucy";
            Trainers jhon = new Trainers();
            jhon.name = "Jhon KS";
                
            ArrayList ani = new ArrayList();
            ani.Add(dog);
            ani.Add(cat);
            ani.Add(elephant);
            ani.Add(jhon);
            foreach (var item in ani)
            {
               if(typeof(Animals)==item.GetType())
                {
                    ((Animals)item).SayHi();
                    ((Animals)item).SayHi();
                }
               else
                {
                    ((Trainers)item).SayHi();
                }

            }


        
        

    }



        struct Animals
        {
            private string Name;

            public string name
            {
                get { return Name; }
                set { Name = value; }
            }

            public void SayHi()
            {
                Console.WriteLine("hello " + Name);
            }
            public void Feed()
            {
                Console.WriteLine(Name + " is eating");
            }
        }

        struct Trainers
        {
            private string Name;

            public string name
            {
                get { return Name; }
                set { Name = value; }
            }

            public void SayHi()
            {
                Console.WriteLine("hello " + Name);
            }
        }


    }
}
