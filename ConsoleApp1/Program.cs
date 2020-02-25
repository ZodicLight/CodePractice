using System; //what is system? namespace. Interact with OS include "Console". Kinda like a shortcut 
              //using System.Linq;
              //using System.Text;
              //using System.Threading.Tasks;
              //look into what those class do above

//Part 20 - C# Tutorial - Static and instance class members.avi
//https://www.youtube.com/watch?v=cFQLmHCguGs

class Circle
{
    float _PI = 3.141F;
    int _Radius;//private?

    public Circle(int Radius)
    {
        this._Radius = Radius;
    }

    public float CalculateArea()
    {
        return this._PI * this._Radius * this._Radius;
    }
}
