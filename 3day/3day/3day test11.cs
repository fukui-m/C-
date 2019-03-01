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
            Console.Write("1から100までの数値を入力してください:");
            var firstInputValue = int.Parse(Console.ReadLine());
            if ( firstInputValue < 1 || 100 < firstInputValue )
            {
                Console.WriteLine("範囲外です。");
            }
            else if (firstInputValue < 20 || 80 <= firstInputValue)
            {
                Console.WriteLine("20未満か、80以上です。");
            }
            else 
            {
                Console.WriteLine("20以上80未満です。");
            }
        }
    }
}
