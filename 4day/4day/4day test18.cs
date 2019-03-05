using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4day
{
    class _4day_test18
    {
        static void Main(string[] args)
        {
            var firstInputValue = 9;
            var minInputValue = 0;
            var maxInputValue = 10;

            for (int i = 1; i <= maxInputValue; i++)
            {
                Console.Write("■");
                for (int j = firstInputValue; minInputValue < j; j--)
                {
                    Console.Write("□");
                }

                if (i < maxInputValue)
                {
                    Console.WriteLine();
                    firstInputValue--;

                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("□");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
