using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3day
{
    class FundCalc
    {
        private decimal number1 = 0;
        private decimal number2 = 0;
        public decimal Number1 { get; set; }
        public decimal Number2 { get; set; }
        public decimal Add()
        {
            return Number1 + Number2;
        } 
        public decimal Sub()
        {
            return Number1 - Number2;
        }
      
    }
}
