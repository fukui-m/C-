using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4day
{
    class _4day_test9
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var minInputValue = 1;
            var maxInputValue = 101;
            while (true)
            {
                int dice = rnd.Next(minInputValue, maxInputValue);
                Console.WriteLine(dice);
                if (dice % 10 == 0)
                {
                    Console.WriteLine("終了します");
                    break;
                }            
            }
        }
    }
}
