using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_5day
{
    class Dummy : IFuncs1,IFuncs2
    {
        public void Func1()
        {
            Console.WriteLine("Funcs1");
        }
        public void Func2()
        {
            Console.WriteLine("Funcs2");
        }
        public void Func3()
        {
            Console.WriteLine("Funcs3");
        }
    }
}
