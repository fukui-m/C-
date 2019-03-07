using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_2day
{
    class Practical_2day_study1_2
    {
        private static int num = 0;
        private int id;
        public Practical_2day_study1_2(int id)
        {
            this.id = id;
            num++;
            Console.WriteLine("値：{0} 数:{1}", this.id, num);
        }
        public static void ShowNumber()
        {
            Console.WriteLine("Dataオブジェクトの数:{0}", num);
        }
    }
}
