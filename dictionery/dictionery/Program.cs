using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionery
{
    class Program
    {
        static void Main(string[] args)
        {
            //create
            Dictionary<string, string> capitals = new Dictionary<string, string>();
            // creating with instantiation
            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                {1,"vikram" },
                {2, "arpitha" },
                {3, "charvi" },
            };
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------");
            

            // add
            capitals.Add("india", "delhi");
            capitals.Add("italy", "rome");
            capitals.Add("england", "london");
            capitals.Add("germany", "berlin");

            // display
            //foreach (var item in capitals)
            //{
            //    Console.WriteLine(item.Value);
            //}

            // or below
            for (int i = 0; i < capitals.Count; i++)
            {
                Console.WriteLine(capitals[capitals.Keys.ElementAt(i)]);
            }
            Console.WriteLine("--------------------------");

            Console.WriteLine(capitals["italy"]);

            // capacity
            Console.WriteLine("--------------------------");
            Console.WriteLine("count is " + capitals.Count);

            // try get value if value is available it sends a boolean output to result  variable
            Console.WriteLine("--------------------------");
            Console.WriteLine(" result is " + capitals.TryGetValue("russia", out string result));
            // returns value for the key
            if (result != null)
                Console.WriteLine("result is " + result);

            //remove
            Console.WriteLine("---------------------------");
            capitals.Remove("italy");
            for (int i = 0; i < capitals.Count; i++)
            {

                Console.WriteLine(capitals[capitals.Keys.ElementAt(i)]);
            }

            //contains
            Console.WriteLine(capitals.ContainsKey("england"));





        }
    }
}
