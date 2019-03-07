using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_2day
{
    class Practical_2day_test3
    {
        static void Square(int firstrnd,int secondrnd)
        {
            if (0 < firstrnd || 0 < secondrnd)
            {
                for (int a = 0; a < firstrnd; a++)
                {
                    for (int b = 0; b < secondrnd; b++)
                    {
                        Console.Write("■ ");
                    }
                    Console.WriteLine();
                }                
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int firstrnd = rnd.Next(1, 11);
            int secondrnd = rnd.Next(1, 11);
            Console.WriteLine("たて:" + firstrnd);
            Console.WriteLine("よこ:" + secondrnd);
            Square(firstrnd, secondrnd);
        }
    }
}
