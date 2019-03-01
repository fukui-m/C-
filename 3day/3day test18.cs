using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3day
{
    class _3day_test18
    {
        static void Main(string[] args)
        {
            Console.Write("温度を入力してください(-10～35):");
            int firstInputValue = int.Parse(Console.ReadLine());
            if (firstInputValue < -10 || 35 < firstInputValue)
            {
                Console.WriteLine("適切な値を入力してください。");
            }
            else if (0 <= firstInputValue && firstInputValue < 25)
            {
                Console.WriteLine("摂氏{0}度", firstInputValue);
            }
            else if (firstInputValue < 0)
            {
                Console.WriteLine("摂氏{0}度", firstInputValue);
                Console.WriteLine("真冬日です");
            }
            else if (25 <= firstInputValue && firstInputValue < 30)
            {
                Console.WriteLine("摂氏{0}度", firstInputValue);
                Console.WriteLine("");
                Console.WriteLine("夏日です");
            }else if (30 <= firstInputValue)
            {
                Console.WriteLine("摂氏{0}度", firstInputValue);
                Console.WriteLine("");
                Console.WriteLine("真夏日です");
            }
        }
    }
}
