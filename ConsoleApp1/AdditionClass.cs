using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTut
{
    //https://www.youtube.com/watch?v=r6rd0fCaqAM
    //AddTwoDoubles.cs
    //AddTwoIntegers.cs
    //summary: good simple tutorial on Abstract class
    abstract class AdditionClass
    {
        abstract public object Total { get; }

        abstract protected object AddTwoValues(object Value1, object Value2);
    }
}
