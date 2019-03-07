using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3day
{
    class Practical_3day_study2_2
    {
        private int param = 0;

        public Practical_3day_study2_2()
        {
            Console.WriteLine("Practical_3day_study2_2クラスのコンストラクタ(引数なし)");
        }
        public Practical_3day_study2_2(int param)
        {
            Console.WriteLine("Practical_3day_study2_2クラスのコンストラクタ(引数:param={0})", param);
            this.param = param;
        }
        ~Practical_3day_study2_2()
        {
            Console.WriteLine("Practical_3day_study2_2クラスのデストラクタ");
        }
        public void ShowParam()
        {
            Console.WriteLine("param = {0}", param);
        }
    }
}
