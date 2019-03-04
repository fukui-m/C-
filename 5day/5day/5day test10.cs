using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _5day_test10
    {
        static void Main(string[] args)
        {
            int[] data = new int[7];
            var dicecount = 0;
            Random rnd = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                int dice = rnd.Next(1, 11);
                Console.Write("{0} ", dice);
                data[i] = dice;
            }
            Console.WriteLine();
            for (int k = 0; k < data.Length; k++)
            {
                for (int j = 0; j < data[dicecount]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                dicecount++;
            }
            Console.ReadLine();
        }
    }
}
