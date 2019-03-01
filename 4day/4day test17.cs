using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4day
{
    class _4day_test17
    {
        static void Main(string[] args)
        {
            var firstInputValue = 1;
            var SecondInputValue = 9;
            for (int i = firstInputValue; i <= 10; i++)
            {
                Console.Write("■");
                if (i+SecondInputValue==10)
                {
                    for (int j = SecondInputValue; 0 < j; j--)
                    {
                        Console.Write("□");
                    }
                }

                if (firstInputValue + SecondInputValue == 10)
                {
                    Console.WriteLine();
                    SecondInputValue--;
                    
                }
            }
        }
    }
}