using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_6day
{
    class Practical_6day_test7
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();
            Random rnd = new Random();
            int dice = 0;
            do
            {
                dice = rnd.Next(0, 11);
                Console.WriteLine("0～10の値を出力:{0}", dice);
                numList.Add(dice);
                IOrderedEnumerable<int> orederedNumList = numList.OrderBy(value => value); 
                if (dice > 0)
                {
                    Console.Write("出力された数:");
                    foreach (int a in orederedNumList)
                    {
                        Console.Write("{0} ", a);
                    }
                }
                Console.WriteLine("");
            } while (dice > 0);
            Console.ReadLine();
        }
    }
}
