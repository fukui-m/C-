using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class Challenge3
    { 
        static void Main(string[] args)
        {
            Console.Write("数値を入力してください:");
            int firstInputValue = int.Parse(Console.ReadLine());
            int[] numlist = new int[firstInputValue];
            int numlistcount = 0;
            int multinum = 1;
            for( int i=firstInputValue; 0<i; i--)
            {
                numlist[numlistcount] = i;
                multinum = multinum * i;
                Console.Write("{0}", numlist[numlistcount]);
                if (1 < i)
                {
                    Console.Write("*");
                    numlistcount++;
                }
                else if (i == 1)
                {
                    Console.Write("={0}",multinum);
                }                
            }
            Console.ReadLine();
        }
    }
}
