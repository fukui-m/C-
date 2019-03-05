using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6day
{
    class _6day_study2_2
    {
        static void Main(string[] args)
        {
            _6day_study2 calc = new _6day_study2();
            int a = 1, b = 2, c = 3;
            int ans1 = calc.Add(a, b);
            int ans2 = calc.Add(a, b, c);
            Console.WriteLine("{0} + {1} + = {2}", a, b, ans1);
            Console.WriteLine("{0} + {1} + {2} = {3}",a,b,c,ans2);
        }
    }
}
