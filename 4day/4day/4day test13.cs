using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4day
{
    class _4day_test13
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var minInputValue = 1;
            var maxInputValue = 11;

            int dice = rnd.Next(minInputValue, maxInputValue);
            if (5 <= dice)
            {
                Console.WriteLine("発生した数値:"+dice);
                for(int i = 1; i <= dice; i++)
                {
                    Console.Write("★");
                }
            }else if (dice < 5)
            {
                Console.WriteLine("発生した数値:" + dice);
                for (int i = 1; i <= dice; i++)
                {
                    Console.Write("☆");
                }

            }
            Console.ReadLine();
        }
    }
}
