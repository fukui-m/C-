using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_1day
{
    class Practical_1day_test2
    {
        static void Main(string[] args)
        {
            Practical_1day_test2_2 p1, p2;
            p1 = new Practical_1day_test2_2();
            p2 = new Practical_1day_test2_2(3, 1);
            p1.Num1 = 1;
            p1.Num2 = 2;
            p1.ShowAdd();
            p2.ShowAdd();
        }
    }
}
