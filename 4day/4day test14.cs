using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4day
{
    class _4day_test14
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var minInputValue = 1;
            var maxInputValue = 11;

            int dice = rnd.Next(minInputValue, maxInputValue);
            if (dice % 2 == 0)
            {
                for (int i = 1; i <= dice; i++)
                {
                    Console.Write("★");
                }
            }
            else
            {
                for (int i = 1; i <= dice; i++)
                {
                    Console.Write("☆");
                }
            }
            Console.ReadLine();

        }
    }
}
