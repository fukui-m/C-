using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4day
{
    class _4day_test16
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 9; i++)
            {
                for(int j = 1; j <= 9; j++)
                {
                    Console.Write("{0}*{1}={2} ",i,j,i*j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
