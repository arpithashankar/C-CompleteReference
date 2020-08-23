using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            Console.WriteLine("what is your name");
            name = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + name +" my name is C#, how old are you");
            age = int.Parse( Console.ReadLine());
            Console.WriteLine(+age + " good");
        }
    }
}
