using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _5day_test7
    {
        static void Main(string[] args)
        {
            int[] data = new int[5];
            int[] dicedata = new int[5];
            var dicecount = 0;
            var sumInputValue = 0;
            Random rnd = new Random();
            for(int i = 0; i < data.Length; i++)
            {
                int dice = rnd.Next(1, 11);
                Console.Write("{0} ", dice);
                sumInputValue = sumInputValue + dice;
                dicedata[dicecount] = dice;
                dicecount++;
            }
            Console.WriteLine();
            Console.WriteLine("合計値:{0}", sumInputValue);
            Console.WriteLine("平均値:{0}", sumInputValue / data.Length);
            Console.WriteLine();
            Console.Write("平均値より大きい数:");
            for(int j = 0; j < data.Length; j++)
            {
                if (sumInputValue / data.Length < dicedata[j])
                {
                    Console.Write("{0} ", dicedata[j]);
                }
            }
            Console.WriteLine();
            Console.Write("平均値より小さい数:");
            for (int k = 0; k < data.Length; k++)
            {
                if (dicedata[k] < sumInputValue / data.Length)
                {
                    Console.Write("{0} ", dicedata[k]);
                }
            }
            Console.ReadLine();
        }
    }
}
