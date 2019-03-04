using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _5day_test3
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            int[] Odddata = new int[10];
            int[] Evendata = new int[10];
            var Oddnum=0;
            var Evennum = 0;
            Random rnd = new Random();
            for(int i=0;i<data.Length;i++)
            {
                int dice = rnd.Next(1,101);
                Console.Write("{0} ",dice);
                if (dice % 2 == 0) 
                {
                    Evendata[Evennum] = dice;
                    Evennum++;
                }
                else
                {
                    Odddata[Oddnum] = dice;
                    Oddnum++;
                }
            }
            Console.WriteLine();
            Console.Write("奇数:");
            for(int j = 0; j < Oddnum; j++)
            {
                Console.Write("{0} ", Odddata[j]);
            }
            
            Console.WriteLine();
            Console.Write("偶数:");
            for(int k = 0; k < Evennum; k++)
            {
                Console.Write("{0} ", Evendata[k]);
            }
           
        }
    }
}
