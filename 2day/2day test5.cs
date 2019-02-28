using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字列1を入力");
            var firstInputValue = Console.ReadLine();
            Console.Write("文字列2を入力");
            var secondInputValue = Console.ReadLine();
            Console.WriteLine("文字列1+文字列2＝{0}", firstInputValue + secondInputValue);
        }
    }
}
