using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6day
{
    class _6day_test3
    {
        static void Main(string[] args)
        {
            _6day_test3_2 c = new _6day_test3_2();
            c.Radius = 4;
            Console.WriteLine("半径" + c.Radius + "の円の円周の長さは" + c.Circumference);
            Console.WriteLine("半径" + c.Radius + "の面積の大きさは" + c.Area);
        }
    }
}
