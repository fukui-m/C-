using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_2day
{
    class Practical_2day_test4
    {
        static void Main(string[] args)
        {
            Practical_2day_test4_2 p1, p2;
            p1 = new Practical_2day_test4_2();
            p2 = new Practical_2day_test4_2();
            p1.Increment();
            p2.Increment();
            p2.Increment();
            p2.Reset();
            p1.Increment();
            p1.Increment();
            p2.Increment();
            Console.WriteLine("p1のカウント数:" + p1.Count);
            Console.WriteLine("p2のカウント数:" + p2.Count);
            Console.WriteLine("トータルのカウント数:{0}", Practical_2day_test4_2.TotalCount(p1.Count, p2.Count));
            Console.ReadLine();
        }
    }
}
