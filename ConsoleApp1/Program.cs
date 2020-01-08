﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace OOP
{
    //Encapsulation 
    //object include property and method 

    class Program
    {
        public static void Main()
        {
            //Procedural programing 
            ////////////////////////
            //int baseSalary = 30000;
            //int overtime = 10;
            //int rate = 20; 

            //function getWage(baseSalary, overtime, rate)
            //{
            //    return baseSalary + (overtime * rate);
            //}

            Employee kevin = new Employee();
            //kevin.GetWage();
            Console.WriteLine(kevin.GetWage());
            Console.ReadLine();

        }
    }

    public class Employee
    {
        public int BaseSalary = 30000;
        public int Overtime = 10;
        public int Rate = 20;
        
        public int GetWage()
        {
            return this.BaseSalary + (this.Overtime * this.Rate);
        } 
    }

}

