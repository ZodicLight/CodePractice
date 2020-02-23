using System; //what is system? namespace. Interact with OS include "Console". Kinda like a shortcut 
              //using System.Linq;
              //using System.Text;
              //using System.Threading.Tasks;
              //look into what those class do above

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Sqrt(144));
            UsefulTools.SayHi("Joe");
            //Console.ReadLine();
        }
    }

    class UsefulTools
    {
        public static void SayHi(string name)
        {
            Console.WriteLine("hello" + name);
        }
    }
}

