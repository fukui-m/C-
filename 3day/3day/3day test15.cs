using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3day
{
    class _3day_test15
    {
        static void Main(string[] args)
        {
            Console.Write("点数(1-100):");
            int firstInputValue = int.Parse(Console.ReadLine());
            if (firstInputValue < 1 || 100 < firstInputValue)
            {
                Console.WriteLine("範囲外");
            }
            else if (80 <= firstInputValue)
            {
                Console.WriteLine("優");
            }
            else if (70 <= firstInputValue && firstInputValue < 80)
            {
                Console.WriteLine("良");
            }
            else if (60 <= firstInputValue && firstInputValue < 70)
            {
                Console.WriteLine("可");
            }else
            {
                Console.WriteLine("不可");
            }
        }
    }
}
