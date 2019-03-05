using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3day
{
    class _3day_test17
    {
        static void Main(string[] args)
        {
            Console.Write("整数を入力してください(1-100):");
            int firstInputValue = int.Parse(Console.ReadLine());
            if (firstInputValue < 1 || 100 < firstInputValue)
            {
                Console.WriteLine("適切な値を入力してください。");
            }else if (firstInputValue <= 50 && firstInputValue % 2 == 0)
            {
                Console.WriteLine("50以下の偶数です。");
            }else if (firstInputValue % 2 == 0)
            {
                Console.WriteLine("偶数です。");
            }
            else if(firstInputValue<=50)
            {
                Console.WriteLine("50以下です。");
            }
        }
    }
}
