using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6day
{
    class _6day_test2
    {
        static void Main(string[] args)
        {
            _6day_test2_1 c = new _6day_test2_1();
            double a = 4.1, b = 2.3;
            Console.WriteLine(a + " + " + b + " = " + c.Add(a, b));
            Console.WriteLine(a + " - " + b + " = " + c.Sub(a, b));
            Console.WriteLine(a + " * " + b + " = " + c.Mull(a, b));
            Console.WriteLine(a + " / " + b + " = " + c.Div(a, b));
        }
    }
}
