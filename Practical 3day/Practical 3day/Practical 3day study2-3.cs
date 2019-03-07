using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3day
{
    class Practical_3day_study2_3:Practical_3day_study2_2
    {
        public Practical_3day_study2_3()
        {
            Console.WriteLine("Practical_3day_study2_3のコンストラクタ(引数なし)");
        }
        public Practical_3day_study2_3(int param) : base(param)
        {
            Console.WriteLine("Practical_3day_study2_3のコンストラクタ(引数:param={0})", param);
        }
        ~Practical_3day_study2_3()
        {
            Console.WriteLine("Practical_3day_study2_3クラスのデストラクタ");
        }
    }
}
