using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3day
{
    class _3day_test14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a,bに1から10までの数値を入力してください。");
            Console.Write("a=");
            int firstInputValue =int.Parse(Console.ReadLine());
            Console.Write("b=");
            int SecondInputValue = int.Parse(Console.ReadLine());
            if (firstInputValue < 1 || 10 < firstInputValue || SecondInputValue <1 || 10 < SecondInputValue)
            {
                Console.WriteLine("範囲外です。");
            }else if (firstInputValue == SecondInputValue)
            {
                Console.WriteLine("等しいです。");
            }else if (firstInputValue > SecondInputValue)
            {
                Console.WriteLine("aのほうが大きいです。");
            }else
            {
                Console.WriteLine("bのほうが大きいです。");
            }
        }
    }
}
