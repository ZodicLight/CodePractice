using System; //what is system? namespace. Interact with OS include "Console". Kinda like a shortcut 
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//look into what those class do above

//Part 33 - C# Tutorial - Difference between abstract classes and interfaces.avi
//https://www.youtube.com/watch?v=hlLqvwocSr4



public abstract class Customer//sealed can't be use.. seal mean can't use as base class 
{
    int ID;

    public void Print()
    {
        Console.WriteLine("Print");
    }
}

public interface ICustomer
{
    //int ID; //No fields

    void Print();
    //public void Print()//Interface can't have implemetation
    //{
    //    Console.WriteLine("Print");
    //}
}

public class Program : Customer
{

    public static void Main()
    {
    }
}

