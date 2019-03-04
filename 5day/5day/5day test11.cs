using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _5day_test11
    {
        static void Main(string[] args)
        {
            int[] data = new int[5];
            Random rnd = new Random();
            for (int i = 0;i < data.Length; i++)
            {
                int dice = rnd.Next(1, 101);
                Console.Write("{0} ", dice);
                data[i] = dice;
            }
            Console.WriteLine();
            Console.Write("0以上60未満:");
            for(int j = 0; j < data.Length; j++)
            {
                if (0 <= data[j] && data[j] < 60)
                {
                    Console.Write("{0} ", data[j]);
                }
            }
            Console.WriteLine();
            Console.Write("60以上80未満:");
            for(int k = 0; k < data.Length; k++)
            {
                if(60<=data[k] && data[k] < 80)
                {
                    Console.Write("{0} ", data[k]);
                }
            }
            Console.WriteLine();
            Console.Write("80以上:");
            for(int l = 0; l < data.Length; l++)
            {
                if (80 <= data[l])
                {
                    Console.Write("{0} ", data[l]);
                }
            }
            Console.ReadLine();
        }
    }
}
