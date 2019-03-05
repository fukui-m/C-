using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7day
{
    class _7day_test3
    {
        static void Main(string[] args)
        {
            _7day_test3_2 c = new _7day_test3_2();
           
            Console.WriteLine("{0}+{1}={2}", c.FirstNumber, c.SecondNumber, c.Add);
            Console.WriteLine("{0}-{1}={2}", c.FirstNumber, c.SecondNumber, c.Sub);
            Console.ReadLine();
        } 
    }
}