using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4day
{
    class _4day_test12
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var minInputValse = 1;
            var maxInputValse = 101;
            int EvenCount = 0, OddCount = 0;

            for (int i = 1; i <= 5; i++)
            {
                int dice = rnd.Next(minInputValse, maxInputValse);
                Console.WriteLine(dice);
                if (dice % 2 == 0)
                {
                    EvenCount++;
                }
                else
                {
                    OddCount++;
                }
            }
            Console.WriteLine("偶数の数:" + EvenCount);
            Console.WriteLine("奇数の数:" + OddCount);
            Console.ReadLine();
        }
    }
}
