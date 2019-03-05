using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6day
{
    class _6day_study1_2
    {
        static void Main(string[] args)
        {
            _6day_study1 p1, p2;
            p1 = new _6day_study1();
            p2 = new _6day_study1();
            p1.name = "山田太郎";
            p1.age = 19;
            p2.SetAgeAndName("佐藤花子", 23);

            p1.ShowAgeAndName();
            p2.ShowAgeAndName();
        }
    }
}
