using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace threadconcepts
{
    class Program
    {
        static Thread t1;
        static Thread t2;

        static void Main(string[] args)
        {
            t1 = new Thread(new ThreadStart(sayhieng));
            t1.Name = "english";
            t1.Start();

            t2 = new Thread(new ThreadStart(syahihindi));
            t2.Name = "hindi";
            t2.Start();
                
        }

        public static void sayhieng()
        {
            Console.WriteLine("startint english"    );
            for (int i = 0; i < 50; i++)
            {
                
                Console.WriteLine(i + " hi");

            }
        }

        public static void syahihindi()
        {
            Console.WriteLine("starting hindi");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i + " namaste");

            }
        }

    }
}
