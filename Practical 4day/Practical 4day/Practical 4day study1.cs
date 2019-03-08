using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_4day
{
    class Practical_4day_study1
    {
        static void Main(string[] args)
        {
            Crow c = new Crow();
            Sparrow s = new Sparrow();
            Console.Write(c.Name+ " : ");
            c.Sing();
            Console.Write(s.Name + " : ");
            s.Sing();
        }
    }
}
