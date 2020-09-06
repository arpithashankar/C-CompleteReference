using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterFour
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demonstrate the % operator.
            int iresult, irem;
            double dresult, drem;
            iresult = 10 / 3;
            irem = 10 % 3;
            dresult = 10.0 / 3.0;
            drem = 10.0 % 3.0;
            Console.WriteLine("Result and remainder of 10 / 3: " +
            iresult + " " + irem);
            Console.WriteLine("Result and remainder of 10.0 / 3.0: " +
            dresult + " " + drem);


            Console.WriteLine("************************************************************************");

            //Demonstrate the difference between prefix and postfix forms of ++.
            Console.WriteLine();
            Console.WriteLine("Demonstrate the difference between prefix and postfix forms of ++");

            int x, y;
            int i;
            x = 1;
            y = 0;
            Console.WriteLine("Series generated using y = y + x++;");
            for (i = 0; i < 10; i++)
            {
                y = y + x++; // postfix ++
                Console.WriteLine(y + " ");
                Console.WriteLine();
                x = 1;
                y = 0;
                Console.WriteLine("Series generated using y = y + ++x;");
                for (i = 0; i < 10; i++)
                {
                    y = y + ++x; // prefix ++
                    Console.WriteLine(y + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("************************************************************************");

            //Demonstrate the relational and logical operators.
            Console.WriteLine();
            Console.WriteLine("Demonstrate the relational and logical operators.");


            int j;
            bool b1, b2;
            i = 10;
            j = 11;
            if (i < j) Console.WriteLine("i < j");
            if (i <= j) Console.WriteLine("i <= j");
            if (i != j) Console.WriteLine("i != j");
            if (i == j) Console.WriteLine("this won't execute");
            if (i >= j) Console.WriteLine("this won't execute");
            if (i > j) Console.WriteLine("this won't execute");
            b1 = true;
            b2 = false;
            if (b1 & b2) Console.WriteLine("this won't execute");
            if (!(b1 & b2)) Console.WriteLine("!(b1 & b2) is true");
            if (b1 | b2) Console.WriteLine("b1 | b2 is true");
            if (b1 ^ b2) Console.WriteLine("b1 ^ b2 is true");

            Console.WriteLine("************************************************************************");

            //Demonstrate the relational and logical operators
            Console.WriteLine();

            Console.WriteLine("Demonstrate the relational and logical operators.");

           // bool b1, b2;
            i = 10;
            j = 11;
            if (i < j) Console.WriteLine("i < j");
            if (i <= j) Console.WriteLine("i <= j");
            if (i != j) Console.WriteLine("i != j");
            if (i == j) Console.WriteLine("this won't execute");
            if (i >= j) Console.WriteLine("this won't execute");
            if (i > j) Console.WriteLine("this won't execute");
            b1 = true;
            b2 = false;
            if (b1 & b2) Console.WriteLine("this won't execute");
            if (!(b1 & b2)) Console.WriteLine("!(b1 & b2) is true");
            if (b1 | b2) Console.WriteLine("b1 | b2 is true");
            if (b1 ^ b2) Console.WriteLine("b1 ^ b2 is true");


            Console.WriteLine("************************************************************************");

            //Use bitwise AND to make a number even.
            Console.WriteLine();

            Console.WriteLine("Use bitwise AND to make a number even.");

            ushort num;
            ushort im;
            for (im = 1; im <= 10; im++)
            {
                num = im;
                Console.WriteLine("num: " + num);
                num = (ushort)(num & 0xFFFE);
                Console.WriteLine("num after turning off bit zero: " + num + "\n");


            }

           
            Console.WriteLine("************************************************************************");

            //Use bitwise AND to determine if a number is odd.
            Console.WriteLine();

            Console.WriteLine("Use bitwise AND to make a number even.");


            ushort num1;
            num1 = 10;
            if ((num1 & 1) == 1)
                Console.WriteLine("This won't display.");
            num1 = 11;
            if ((num1 & 1) == 1)
                Console.WriteLine(num1 + " is odd.");


            Console.WriteLine("************************************************************************");

            //Demonstrate the shift << and >> operators
            Console.WriteLine();

            Console.WriteLine("Demonstrate the shift << and >> operators.");

            int val = 1;
            for (i = 0; i < 8; i++)
            {
                for (int t = 128; t > 0; t = t / 2)
                {
                    if ((val & t) != 0) Console.Write("1 ");
                    if ((val & t) == 0) Console.Write("0 ");
                }
                Console.WriteLine();
                val = val << 1; // left shift
            }
            Console.WriteLine();
            val = 128;
            for (i = 0; i < 8; i++)
            {
                for (int t = 128; t > 0; t = t / 2)
                {
                    if ((val & t) != 0) Console.Write("1 ");
                    if ((val & t) == 0) Console.Write("0 ");
                }
                Console.WriteLine();
                val = val >> 1; // right shift

            }
        }
    }
}

