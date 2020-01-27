using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass MyObject = new MyClass(5, 7);

            //MyObject.Total = 23;
            Console.WriteLine(MyObject.Total);

        }


    }
    
}

