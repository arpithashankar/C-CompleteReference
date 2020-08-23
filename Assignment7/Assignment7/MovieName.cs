using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNameSpa
{
    struct Moviename
    {
        private string movie;

        public string Movie
        {
            get { return movie; }
            set { movie = value; }
        }

        private int rate;

        public int Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        private DateTime releasedate;

        public DateTime ReleaseDate
        {
            get { return releasedate; }
            set { releasedate = value; }
        }

        private  generes[] generes;

        public generes[] Generes
        {
            get { return generes; }
            set { generes = value; }
        }


        private languages[] languages;

        public languages[] Languages
        {
            get { return languages; }
            set { languages = value; }
        }

        private country[] countries;

        public country[] Country
        {
            get { return countries; }
            set { countries = value; }
        }

        public void displayinfo ()
        {
            Console.WriteLine("Movies : " + Movie + "\n\nRate : " +Rate + " out of 10" + "\n\nReleased Date : " 
                + ReleaseDate.ToShortDateString());
            Console.Write("\nLanguages :  ");

            for (int i = 0; i < languages.Length; i++)
            {
                Console.Write(languages[i]);
                if (i < Languages.Length - 1)
                    Console.Write(", ");
                else
                    Console.WriteLine();

            }
            Console.Write("\nGeneres :  ");

            for (int i = 0; i < generes.Length; i++)
            {
                Console.Write(generes[i]);
                if (i < generes.Length - 1)
                    Console.Write(", ");
                else
                    Console.WriteLine();

            }
            Console.Write("\nCountries :  ");

            for (int i = 0; i < countries.Length; i++)
            {
                Console.Write(countries[i]);
                if (i < countries.Length - 1)
                    Console.Write(", ");
                else
                    Console.WriteLine();

            }

        }
    }

    enum languages
    {
        kannada, english, hindi
    };


    enum generes
    {
        comedy, drama, romantic
    };

    enum country
    {
        india, US, Germany
    };





    }

