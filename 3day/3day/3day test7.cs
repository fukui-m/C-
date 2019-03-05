using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数値を入力");
            int firstInputValue = int.Parse(Console.ReadLine());
            if (firstInputValue % 2 == 0)
            {
                Console.WriteLine("この数は偶数です。");
            }else
            {
                Console.WriteLine("この数は奇数です。");
            }
        }
    }
}
