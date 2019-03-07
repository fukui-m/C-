using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_2day
{
    class Practical_2day_study2
    {
        private static int snum = 100;
        public int inum = 200;
        public static void Foo()
        {
            Console.WriteLine("fooメソッド(staticメソッド)");
        }
        public void Bar()
        {
            Console.WriteLine("barメソッド(インスタンスメソッド)");
        }
        static void Main(string[] args)
        {
            Practical_2day_study2 p = new Practical_2day_study2();
            Console.WriteLine("pのインスタンスフィールド:inum = {0}", p.inum);
            Console.WriteLine("Practical_2day_study2のクラスフィールド:snum = {0}", snum);
            Foo();
            p.Bar();
        }
    }
}
