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
            int num = int.Parse(Console.ReadLine());
            if (num < 50)
            {
                Console.WriteLine("50未満です");
            }
        }
    }
}
