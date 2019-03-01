using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4day
{
    class _4day_study5
    {
        static void Main(string[] args)
        {
            int i, num;
            num = 1;

            Console.Write("whileで実行:");
            i = 1;
            while (i < num)
            {
                Console.Write("*");
                i++;
            }
            Console.WriteLine();
            Console.Write("do～whileで実行");
            i = 1;
            do
            {
                Console.WriteLine("*");
                i++;
            } while (i < num);
        }
    }
}