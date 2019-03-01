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
            Console.Write("文字列1を入力:");
            var firstInputChar = Console.ReadLine();
            Console.Write("文字列2を入力:");
            var SecondInputChar = Console.ReadLine();
            if (firstInputChar == SecondInputChar)
            {
                Console.WriteLine("2つの文字列は等しい");
            }else
            {
                Console.WriteLine("2つの文字列は等しくない");
            }
        }
    }
}
