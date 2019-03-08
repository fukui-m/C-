using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3day
{
    class NewCalc:FundCalc
    {
        public decimal Mul()
        {
            return number1 * number2;
        }
        public decimal Div()
        {
            return number1 / number2;
        }
    }
}
