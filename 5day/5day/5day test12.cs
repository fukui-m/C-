using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _5day_test12
    {
        static void Main(string[] args)
        {
            int[,] data = new int[3, 3];
            Random rnd = new Random();
            for(int row = 0; row< 3; row++)
            {
                for(int line = 0; line < 3; line++)
                {
                    int dice = rnd.Next(1, 10);
                    Console.Write("{0} ", dice);
                }
                Console.WriteLine();
            }Console.ReadLine();
        }
    }
}
