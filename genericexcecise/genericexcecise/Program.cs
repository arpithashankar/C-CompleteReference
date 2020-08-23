using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericexcecise
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstlist = new List<movies<double, DateTime>>();


            movies<double, DateTime> mn = new movies<double, DateTime>();
            mn.MovieName = "premaloka";
            mn.Director = "hamsalekha";
            mn.Rate = 10;
            mn.ReleaseDAte = new DateTime(2001, 05, 13);

            movies<double, DateTime> ab = new movies<double, DateTime>();
            ab.MovieName = "raja";
            ab.Director = "dkhsd";
            ab.Rate = 8.8;
            ab.ReleaseDAte = new DateTime(2015, 9, 26);

            movies<double, DateTime> xy = new movies<double, DateTime>();
            xy.MovieName = "jeevan";
            xy.Director = "dkhsd";
            xy.Rate = 9;
            xy.ReleaseDAte = new DateTime(2006, 08, 20);

            firstlist.Add(mn);
            firstlist.Add(ab);
            firstlist.Add(xy);


        }


    }

    class movies<T, U>
    {
        private string moviename;

        public string MovieName
        {
            get { return moviename; }
            set { moviename = value; }
        }

        private string director;

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        private U releasedate;

        public U ReleaseDAte
        {
            get { return releasedate; }
            set { releasedate = value; }
        }

        private T rate;

        public T Rate
        {
            get { return rate; }
            set { rate = value; }
        }



    }
}
