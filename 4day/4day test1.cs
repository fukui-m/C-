using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4day
{
    class _4day_test1
    {
        static void Main(string[] args)
        {
            Console.Write("数:");
            int firstInputValue = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= firstInputValue; i++) { 
            Console.Write("■" + " ");
            }
            Console.ReadLine();
        }
    }
}
