using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignmrnt9
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("enter the mode");
            Console.WriteLine("enter e to encrypt \n enter d to decrypy \n enter x to stop");
            char mode =char.Parse ( Console.ReadLine());
            if (mode == 'e')
            {
                string message;
                Console.WriteLine("enter the message to be encrypted");
                message = Console.ReadLine();
                Console.WriteLine("enter the key");
                int key = int.Parse(Console.ReadLine());

                char[] cipherText = encryption(message, key);
                Console.WriteLine(cipherText);
            }

            else if (mode =='d')
            {
                string cp;
                StreamReader Cp=File.OpenRead(@"E:\c#\msg.txt");
            }

        }
               
        
        public static char[] encryption(string message, int key)
        {
            char[] plainarray = message.ToLower().ToCharArray();
            char[] CipherArray = new char[plainarray.Length];

            for (int i = 0; i < plainarray.Length; i++)
            {
                char letter = plainarray[i];
                if (letter != ' ')
                {
                    letter = (char)(letter + key);

                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);

                    }
                    CipherArray[i] = letter;

                }
               
            }
            return CipherArray;

        }
    }
}
