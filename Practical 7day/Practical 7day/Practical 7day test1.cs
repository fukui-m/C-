using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7day
{
    class Practical_7day_test1
    {
        delegate void Delfunc();
        static void Func1()
        {
            Console.WriteLine("Func1");
        }
        static void Func2()
        {
            Console.WriteLine("Func2");
        }
        static void Main(string[] args)
        {
            Delfunc df = new Delfunc(Func2);
            df();
            Console.ReadLine();
        }
    }
}
