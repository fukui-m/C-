using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class Challenge5
    {
        static void Main(string[] args)
        {
            var lowerfirstnum = 0;
            Console.WriteLine("3で割り切れるか、数値の中に3が含まれる数");
            for (int i = 1; i <= 100; i++)
            {
                lowerfirstnum++;
                if (i % 3 == 0|| lowerfirstnum == 3||30 <= i&&i<=39)
                {
                    Console.WriteLine(i);
                }
                if (lowerfirstnum == 10)
                {
                    lowerfirstnum = 0;
                }
            }
        }
    }
}
