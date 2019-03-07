using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_2day
{
    class Practical_2day_study1
    {
        static void Main(string[] args)
        {
            Practical_2day_study1_2[] p = new Practical_2day_study1_2[2];
            Practical_2day_study1_2.ShowNumber();
            for(int i = 0; i < p.Length; i++)
            {
                p[i] = new Practical_2day_study1_2(i * 100);
                Practical_2day_study1_2.ShowNumber();
            }
           
        }
    }
}
