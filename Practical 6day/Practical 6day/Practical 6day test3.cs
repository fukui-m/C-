using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_6day
{
    class Practical_6day_test3
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();
            Random rnd = new Random();
            int dice = 0;
            do
            {
                dice = rnd.Next(0, 101);
                Console.WriteLine("0～100の値を出力:{0}", dice);               
                if (dice ==0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    numList.Add(dice);
                }
            } while (0<dice);
            for(int i = 0; i <=9; i++)
            {
                int numCheck = 0;
                Console.Write("一の位が{0}:",i);
                foreach (int a in numList)
                {
                    if (a%10==i)
                    {
                        Console.Write("{0} ", a);
                        numCheck++;
                    }                  
                }
                if (numCheck == 0)
                {
                    Console.Write("なし");
                }
                Console.WriteLine("");
               
            }
            Console.ReadLine();
        }
    }
}
