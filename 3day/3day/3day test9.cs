
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
            Console.Write("文字列を入力:");
            var firstInputChar = Console.ReadLine();
            if (firstInputChar == "abc")
            {
                Console.WriteLine("abcです。");
            }
            else
            {
                Console.WriteLine("abcではありません。");
            }
        }
    }
}
