using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _5day_test13
    {
         static void Main(string[] args)
        {
            int[,] data = new int [ 3, 3 ];
            var maxInputValue = 0;
            var minInputValue = 9;
            Random rnd = new Random();
            for (int i = 0;i < 3; i++){
                for (int j = 0;j < 3; j++){
                    int dice = rnd.Next(1, 10);
                    Console.Write("{0} ", dice);
                    if (maxInputValue < dice)
                    {
                        maxInputValue = dice;
                    }else if (dice < minInputValue)
                    {
                        minInputValue = dice;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("最大値:{0}", maxInputValue);
            Console.Write("最小値:{0}", minInputValue);
            Console.ReadLine();
         }
    }
}
