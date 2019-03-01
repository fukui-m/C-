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
            if (firstInputValue < 50)
            {
                Console.WriteLine("50未満です");
            }
        }
    }
}
