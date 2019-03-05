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
            var minInputValue = 0;
            var maxInputValue = 10;
            for (int i = firstInputValue; i <= maxInputValue; i++)
            {
                Console.Write("■");

                if (i+SecondInputValue==maxInputValue)
                {
                    for (int j = SecondInputValue; minInputValue< j; j--)
                    {
                        Console.Write("□");
                    }
                }

                if (i + SecondInputValue == maxInputValue && minInputValue<SecondInputValue)
                {
                    Console.WriteLine();
                    SecondInputValue--;
                    i = minInputValue;
                }
            }
            Console.ReadLine();
        }
    }
}