using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _5day_test6
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            var maxInputValue = 0;
            var minInputValue = 10;
            var sumInputValue = 0;
            Random rnd = new Random();
            for(int i = 0; i < data.Length; i++)
            {
                int dice = rnd.Next(1, 11);
                Console.Write("{0} ", dice);
                sumInputValue = sumInputValue + dice;
                if (maxInputValue < dice)
                {
                    maxInputValue = dice;
                }else if (dice < minInputValue)
                {
                    minInputValue = dice;
                }
            }
            Console.WriteLine();
            Console.WriteLine("最大値 : {0}",maxInputValue);
            Console.WriteLine("最小値 : {0}",minInputValue);
            Console.WriteLine("平均値 : {0}", sumInputValue / data.Length);
            Console.ReadLine();
        }
    }
}
