using System; //what is system? namespace. Interact with OS include "Console". Kinda like a shortcut 
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//look into what those class do above


namespace ConsoleApplication1
{
    public abstract class AbstractClass
    {
        public virtual void AbstractClassMethod()
        {
            Console.WriteLine("Default Implementation");
        }
    }

    public class SomeClass : AbstractClass
    {
        
    }

    public class SomeOtherClass : AbstractClass
    {
        public override void AbstractClassMethod()
        {
            Console.WriteLine("new Implementation");
        }
    }
    
    class Program
    {
        public static void Main()
        {
            SomeClass temp = new SomeClass();
            temp.AbstractClassMethod();

            SomeOtherClass soc = new SomeOtherClass();
            soc.AbstractClassMethod();

        }

    }
    

}

