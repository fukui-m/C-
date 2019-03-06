using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class Challenge5_ver2
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("3で割り切れるか、数値の中に3が含まれる数");
            for (int num = 1; num <= 100; num++)
            {
                if (num.ToString().Contains("3")||num % 3 == 0 )
                {
                    Console.WriteLine(num);
                }
                
            }
        }
    }
}
