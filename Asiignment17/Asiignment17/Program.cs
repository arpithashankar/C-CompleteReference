using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asiignment17
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "hi how are you ";
            Console.WriteLine(word.CapitalizeFirstLetter());
        }
    }



    public static class capitalize
    {
        public static string CapitalizeFirstLetter(this string word)
        {
            char[] letters = word.ToLower().ToCharArray();

            if(letters.Length>=1)
            {
                if(char.IsLower(letters[0]))
                {
                    letters[0] = char.ToUpper(letters[0]);
                }
            }

            for (int i = 1; i < letters.Length; i++)
            {
                if(letters[i-1]==' ')
                {
                   if(char.IsLower(letters[i]))
                    {
                        letters[i] = char.ToUpper(letters[i]);
                    }
                }


            }



            return new string(letters);

        }
        

    }
}
