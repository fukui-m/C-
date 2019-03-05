using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6day
{
    class _6day_test1
    {
        static void Main(string[] args)
        {
            _6day_test1_2 m = new _6day_test1_2();
            int a = 5, b = 2,c=1 ;
            Console.WriteLine("{0}と{1}と{2}のうち、最大のものは{3}", a, b,c,m.Max(a,b,c,maxInputValue));
            Console.WriteLine("{0}と{1}と{2}のうち、最小のものは{3}", a, b,c,m.Min(a,b,c,minInputValue));
        }
    }
}
