using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "Dog");
            //Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            //Rating: G, PG, PG-13, R , NR
            //avengers.rating = "dog";//this is bad 
            shrek.Rating = "R"; //should return NR??
            Console.WriteLine(shrek.Rating);

        }


    }
    
}

