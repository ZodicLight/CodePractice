using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//look into what those class do above


namespace AbstractionTut
{
    static class Program//static here? Why?
    {
        static void Main(string[] args)
        {
            AdditionClass AddTwoDouble = new AddTwoDoubles(343.2,432.5);
            AdditionClass AddTwoInt = new AddTwoIntegers(33,34);

        }
    }
}
