using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_4day
{
    class Practical_4day_test2
    {
        static void Main(string[] args)
        {
            Box b = new Box(2.0,4.0);
            Triangle t = new Triangle(4.0, 1.5);
            Console.WriteLine("幅{0}、高さ{1}の四角形の面積は{2}", b.Width, b.Heigth, b.Area);
            Console.WriteLine("幅{0}、高さ{1}の三角形の面積は{2}", t.Width, t.Heigth, t.Area);
        }
    }
}
