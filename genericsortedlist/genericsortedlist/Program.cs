using System;
using System.Collections; // namespace for non generic
using System.Collections.Generic; // name space for generic
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericsortedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList list = new SortedList(); // non generic sorted list
            SortedList<string, string> phonebook = new SortedList<string, string>(); //generic sorted list

            //adding
            phonebook.Add("asi", "4215");
            phonebook.Add("saa", "8112");
            phonebook.Add("gjhsdh", "5145");
            phonebook.Add("xjl", "++64");

            foreach (var item in phonebook)
            {
                Console.WriteLine(item.Key + " ," + item.Value);
            }

            //index
            phonebook["asi"] = "123456789";
            Console.WriteLine(phonebook.IndexOfKey("asi"));

            // trygetvalue
            Console.WriteLine(phonebook.TryGetValue("saa", out string result)); // output is boolean
            //Console.WriteLine("result is " + result); // output is value corresponding to key


        


        }
    }
}
