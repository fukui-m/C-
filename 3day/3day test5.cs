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
            Console.WriteLine("整数値を入力してください");
            int firstInputValue = int.Parse(Console.ReadLine());
            if (30 < firstInputValue && firstInputValue<= 70)
            {
                Console.WriteLine("30より大きく70以下です");
            }
        }
    }
}
