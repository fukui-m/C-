using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3day
{
    class _3day_test16
    {
        static void Main(string[] args)
        {
            Console.Write("数値を入力:");
            int firstInputValue = int.Parse(Console.ReadLine());
            if (firstInputValue % 6 == 0)
            {
                Console.WriteLine("2と3の公倍数です。");
            }
            else if (firstInputValue % 3 == 0)
            {
                Console.WriteLine("3の倍数です。");
            }
            else if (firstInputValue % 2 == 0)
            {
                Console.WriteLine("2の倍数です。");
            }
            else
            {
                Console.WriteLine("範囲外です。");
            }
        }
    }
}
