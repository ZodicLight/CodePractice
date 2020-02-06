using System; //what is system? namespace. Interact with OS include "Console". Kinda like a shortcut 
//https://www.youtube.com/watch?v=vfH16HK8fPo
//https://docs.microsoft.com/en-us/dotnet/api/system?view=netframework-4.8

//using System.Collections.Generic;
//https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic?view=netframework-4.8

//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//look into what those class do above

//Part 30 - C# Tutorial - Interfaces in c#.avi
//https://www.youtube.com/watch?v=D6d8CIVoYSI

interface ICustomer
{
    void Print();
}

interface ICustomer2 : ICustomer
{
    void Print2();
}


interface I2
{
    void I2Method();
}

public class Customer : ICustomer2
{
    public void Print()
    {
        Console.WriteLine("interface print method");
    }

    public void Print2()
    {
        Console.WriteLine("Interface Print Method2");
    }

}

//public class Customer : ICustomer, I2
//{
//    public void Print()
//    {
//        Console.WriteLine("Interface Print Method");
//    }

//    public void I2Method()
//    {
//        Console.WriteLine("I2 Method");
//    }

//}

public class Sample
{

}


public class Program 
{
    public static void Main()
    {
        Customer C1 = new Customer();//C1 is an object reference?
        ICustomer C2 = new Customer();//this is aloud like 
        C2.Print();
        //C2.Print2();//not aloud because ICustomer only has Print() method

        C1.Print();
        C1.Print2();
    }
}