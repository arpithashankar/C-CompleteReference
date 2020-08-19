using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Movies<double,DateTime> movieDetails = new Movies<double,DateTime>();
            movieDetails.Name = "lol";
            movieDetails.Director = "abc";
            movieDetails.Rate = 8.0;
            movieDetails.Date = new DateTime(2019,12,10);

            Movies<double, DateTime> movieDetails1 = new Movies<double, DateTime>();
            movieDetails1.Name = "abc";
            movieDetails1.Director = "pqr";
            movieDetails1.Rate = 9.9;
            movieDetails1.Date = new DateTime(2020, 08, 10);

            List<Movies<double,DateTime>> listmoviesone = new List<Movies<double, DateTime>>();
            listmoviesone.Add(movieDetails);
            listmoviesone.Add(movieDetails1);

            

        }
    }
    class Movies<T, U>
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string director;

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        private T rate;
                    
        public T Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        private U date;

        public U Date
        {
            get { return date; }
            set { date = value; }
        }




    }
}
