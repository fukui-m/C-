using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_4day
{
    class Practical_4day_study2
    {
        static void Main(string[] args)
        {
            Bird[] b = new Bird[2];
            b[0] = new Crow();
            b[1] = new Sparrow();
            for(int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i].Name + " : ");
                b[i].Sing();
            }
        }
    }
}
