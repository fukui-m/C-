using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4day
{
    class _4day_test2
    {
        static void Main(string[] args)
        {
            Console.Write("数:");
            int firstInputValue = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int i = 1;
            while (i <= firstInputValue)
            {
                Console.Write("■" + " ");
                i++;
            }
            Console.ReadLine();

        }
    }
}
