using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTut
{
    class AddTwoIntegers: AdditionClass
    {
        private int _total;

        public AddTwoIntegers(int value1, int value2)
        {
            _total = (int)this.AddTwoValues(value1, value2);
        }

        public override object Total
        {
            get
            {
                return _total;
            }
        }

        protected override object AddTwoValues(object Value1, object Value2)
        {
            int sum = (int)Value1 + (int)Value2;
            return sum;
       
        }

    }
}
