using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4day 
{
    class _4day_test10
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var minInputValue = 1;
            var maxInputValue = 101;
            for(int i = 1; i <= 5; i++)
            {
                int dice = rnd.Next(minInputValue, maxInputValue);
                Console.WriteLine(dice);
            }
            Console.ReadLine();
        }
    }
}
