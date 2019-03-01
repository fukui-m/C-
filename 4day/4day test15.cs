using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4day
{
    class _4day_test15
    {
        static void Main(string[] args)
        {
            var minInputValue = 1;
            var maxInputValue = 100;

            for (int i = minInputValue; i <= maxInputValue; i++)
            {
                Console.Write(i + " ");
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
