using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4day
{
    class _4day_test8
    {
        static void Main(string[] args)
        {
            var minInputValue = 0;
            while (true)
            {
                Console.Write("0以上の数値を入力してください:");
                int firstInputValue = int.Parse(Console.ReadLine());
                Console.WriteLine(firstInputValue);

                if (firstInputValue < minInputValue)
                {
                    break;
                }
            }
                Console.ReadLine();
            
        }
    }
}
