using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7day
{
    class Practical_7day_test2
    {
        delegate void Delegatefunc(int num);
        class Showchras
        {
            public void ShowStars(int num)
            {
                for(int i = 0; i < num; i++)
                {
                    Console.Write("☆");
                }
                Console.WriteLine();
            }
            public void ShowBoxes(int num)
            {
                for(int i = 0; i < num; i++)
                {
                    Console.Write("■");
                }
                Console.WriteLine();
            }
            public void ShowPlus(int num)
            {
                for(int i = 0; i < num; i++)
                {
                    Console.Write("＋");
                }
                Console.WriteLine();
            }
        }
        class Program
        {
             static void Main(string[] args)
            {
                Showchras s = new Showchras();
                Delegatefunc f = new Delegatefunc(s.ShowStars);
                f += new Delegatefunc(s.ShowBoxes);
                f += new Delegatefunc(s.ShowPlus);
                f(4);
            }
        }
    }
}
