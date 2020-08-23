using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieNameSpa;

namespace Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {

            Moviename details = new Moviename();
            details.Movie = "raja";
            details.Rate = 8;
            details.ReleaseDate = DateTime.Now.Date;

            details.Languages = new languages[2];
            details.Languages[0] = languages.english;
            details.Languages[1] = languages.hindi;

            details.Generes = new generes[1];
            details.Generes[0] = generes.comedy;

            details.Country = new country[2];
            details.Country[0] = country.Germany;


            details.Country[1] = country.india;


            details.displayinfo();


        }
    }
      
   
}
