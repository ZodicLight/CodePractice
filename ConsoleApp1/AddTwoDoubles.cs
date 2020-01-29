using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTut
{
    class AddTwoDoubles: AdditionClass
    {
        private double _total;

        public AddTwoDoubles(double value1, double value2)//constructor 
        {
            _total = (double)this.AddTwoValues(value1, value2);
        }

        public override object Total
        {
            get
            {
                return _total; 
                //throw new NotImplementedException();
            }
        }

        protected override object AddTwoValues(object Value1, object Value2)
        {
            double sum = (double)Value1 + (double)Value2;// cannot apply to object. how object datatype work? can't have + two objects together 
            return sum; 
            //throw new NotImplementedException();
        }
    }
}
