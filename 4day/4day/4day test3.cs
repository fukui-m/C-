using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4day
{
    class _4day_test3
    {
        static void Main(string[] args)
        {
            Console.Write("数:");
            int firstInputValue = int.Parse(Console.ReadLine());
            int i = 1;
            if (i <= firstInputValue) {        
                do
                {
                    Console.Write("■" + " ");
                    i++;
                } while (i <= firstInputValue);
            }
            Console.ReadLine();
        }
    }
}
