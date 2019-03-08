using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3day
{
    class Practical_3day_test1
    {
        static void Main(string[] args)
        {
            Fighter f = new Fighter();
            Airplane a = new Airplane();
            a.Fly();
            f.Fly();
            Fighter.Fight();
        }
    }
}
