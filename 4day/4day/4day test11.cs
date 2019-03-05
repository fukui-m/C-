using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4day
{
    class _4day_test11
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var minInputValse = 1;
            var maxInputValse = 101;
            var minOutputValue = 100;
            var maxOutputValue = 1;

            for (int i = 1; i <= 5; i++)
            {
                int dice = rnd.Next(minInputValse, maxInputValse);
                Console.WriteLine(dice);
                if (maxOutputValue<dice)
                {
                    maxOutputValue=dice;
                }
                else if (dice < minOutputValue)
                {
                    minOutputValue = dice;   
                }
            }
            Console.WriteLine("最大値:" + maxOutputValue);
            Console.WriteLine("最小値:" + minOutputValue);
            Console.ReadLine();
        }
    }
}
