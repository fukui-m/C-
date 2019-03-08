using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3day
{
    class FundCalc
    {
        protected decimal number1 = 0;
        protected decimal number2 = 0;
        public decimal Number1
        {
            set { number1 = value; }
            get { return number1; }
        }
        public decimal Number2
        {
            set { number2 = value; }
            get { return number2; }
        }
        public decimal Add()
        {
            return number1 + number2;
        } 
        public decimal Sub()
        {
            return number1 - number2;
        }
      
    }
}
