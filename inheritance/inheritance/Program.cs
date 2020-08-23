using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            dogs dog = new dogs();
            birds bird=new birds()
                
            
        }
    }

    class Animal
    {
        public string AnimalNames;
        public DateTime AnimalBirthDate;
        public void FeedAnimal()
        {

        }

    }
    class dogs: Animal
    {
        public string DogBreed;
        public String DogIntelligence;

    }

    class birds:Animal
    {
        public string birdcolor;
        public string birdCountry;
    }


}
