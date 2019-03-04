using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _5day_test9
    {
        static void Main(string[] args)
        {
            int[] data = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[]Largedata = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[]Smalldata = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var Largedatacount = 0;
            var Smalldatacount = 0;
            var zerothcount = 0;
            Random rnd = new Random();
            for(int i = 0; i < data.Length; i++)
            {
                int dice = rnd.Next(1, 101);
                Console.Write("{0} ", dice);
                if (dice == 0)
                {
                    zerothcount++;
                }else if (50 <= dice)
                {
                    Largedata[Largedatacount] = dice;
                    Largedatacount++;
                }else if (dice < 50)
                {
                    Smalldata[Smalldatacount] = dice;
                    Smalldatacount++;
                }
            }
            Console.WriteLine();
            Console.Write("50以上の数:");
            for(int j=0; j < Largedatacount; j++)
            {
                Console.Write("{0} ", Largedata[j]);
            }
            Console.WriteLine();
            Console.Write("50未満の数:");
            for(int k = 0; k < Smalldatacount; k++)
            {
                Console.Write("{0} ", Smalldata[k]);
            }
            Console.WriteLine();
            Console.WriteLine("0の個数:{0}", zerothcount);
            Console.ReadLine();
        }
    }
}

