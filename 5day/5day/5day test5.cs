using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _5day_test5
    {
        static void Main(string[] args)
        {
            int[] data = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] Multidata = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] Otherdata = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var Multinum = 0;
            var Othernum = 0;
            Random rnd = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                int dice = rnd.Next(1, 11);
                Console.Write("{0} ", dice);
                if (dice % 3 == 0.0)
                {
                    Multidata[Multinum] = dice;
                    Multinum++;
                }
                else
                {
                    Otherdata[Othernum] = dice;
                    Othernum++;
                }
            }
            Console.WriteLine();
            Console.Write("3の倍数:");
            for (int j = 0; j < Multinum; j++)
            {
                Console.Write("{0} ", Multidata[j]);
            }
            Console.WriteLine();
            Console.Write("3の倍数以外の数:");
            for (int k = 0; k < Othernum; k++)
            {
                Console.Write("{0} ", Otherdata[k]);
            }
            Console.ReadLine();
        }
    }
}
