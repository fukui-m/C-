using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _5day_test4
    {
        static void Main(string[] args)
        {
            int[] data = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] Largedata = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] Smalldata = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var Largenum = 0;
            var Smallnum = 0;
            Random rnd = new Random();
            for(int i = 0; i < data.Length; i++)
            {
                int dice = rnd.Next(1, 101);
                Console.Write("{0} ", dice);
                if (50 <= dice)
                {
                    Largedata[Largenum] = dice;
                    Largenum++;
                }
                else 
                { 
                    Smalldata[Smallnum] = dice;
                    Smallnum++;
                }
            }
            Console.WriteLine();
            Console.Write("50以上の数:");
            for(int j = 0; j < Largenum; j++)
            {
                Console.Write("{0} ", Largedata[j]);
            }
            Console.WriteLine();
            Console.Write("50未満の数:");
            for(int k = 0; k < Smallnum; k++)
            {
                Console.Write("{0} ", Smalldata[k]);
            }
            Console.ReadLine();
        }
    }
}
