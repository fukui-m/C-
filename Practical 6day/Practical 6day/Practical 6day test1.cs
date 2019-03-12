using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_6day
{
    class Practical_6day_test1
    {
        static void Main(string[] args)
        {
            List<int> addNumber = new List<int>();
            List<int> evenNumber = new List<int>();
            Random rnd = new Random();
            int dice = 0;
            do
            {
                dice = rnd.Next(0, 11);
                Console.WriteLine("0～10の値を出力:{0}",dice);
                if(dice==0)
                {
                    Console.WriteLine("");
                }
                else if (dice % 2 != 0)
                {
                    addNumber.Add(dice);
                }else if (dice % 2 == 0)
                {
                    evenNumber.Add(dice);
                }

            } while (dice >0);
            Console.Write("奇数:");
            foreach(int a in addNumber)
            {
                Console.Write(a+" ");
            }
            Console.WriteLine("");
            Console.Write("偶数:");
            foreach(int e in evenNumber)
            {
                Console.Write(e+" ");
            }
            Console.ReadLine();
        }
    }
}
