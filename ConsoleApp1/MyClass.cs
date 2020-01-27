using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class MyClass
    {
        private int _total; 

        public int Total
        {
            get { return _total; }//retunr private _total
            //set { _total = value; }//remove this otherwise allow the user to break the code. User has no way to mis use this class. 
        }

        public MyClass(int Value1, int Value2)
        {
            _total = addTwoIntegers(Value1, Value2);
        }

        private int addTwoIntegers(int value1, int value2 = 0)
        {
            int sum = value1 + value2;
            return sum;
        }
    }
}
