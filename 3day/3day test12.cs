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
            Console.Write("整数を入力してください:");
            int firstInputValse = int.Parse(Console.ReadLine());
            if (firstInputValse < 0)
            {
                Console.WriteLine("負の値です");
            }else if (0 < firstInputValse)
            {
                Console.WriteLine("正の値です");
            }else
            {
                Console.WriteLine("0です");
            }
        }
    }
}
