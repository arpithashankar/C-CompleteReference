using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace threadexcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(delegate ()
              {
                  for (int i = 0; i < 10; i++)
                  {
                      Console.WriteLine("hello from anonymous thread");
                  }

              }));
            t1.Start();
        }
    }
}
