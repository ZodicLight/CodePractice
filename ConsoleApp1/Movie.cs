using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Movie
    {
        public string title;
        public string director;
        //public string rating;
        private string _rating;//getter and setter

        public Movie(string aTitle, string aDirector, string aRating)//constructor 
        {
            title = aTitle;
            director = aDirector;
            //rating = aRating;
            Rating = aRating;//Rating is calling the method Rating 
        }

        public string Rating
        {
            get { return _rating; }

            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    _rating = value;
                }
                else
                {
                    _rating = "NR";
                }
            }
        }
    }
}
