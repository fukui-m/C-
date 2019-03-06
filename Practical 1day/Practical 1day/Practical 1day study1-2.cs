using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_1day
{
    class Practical_1day_study1_2
    {
        static void Main(string[] args)
        {
            Practical_1day_study1 p1,p2;
            p1 = new Practical_1day_study1();
            p2 = new Practical_1day_study1("大田隆",29);
            p1.Name = "斉藤花子";
            p1.Age = 18;
            p1.ShowAgeAndName();
            p2.ShowAgeAndName();
        }
    }
}
