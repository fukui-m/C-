using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _5day_test1
    {
        static void Main(string[] args)
        {
            int []box = { 0, 1, 2, 3, 4, 5, 6 };
            Random rnd = new Random();
            
            for (int i = 0;i < box.Length; i++){
                int dice = rnd.Next(1, 11);
                Console.Write("a[{0}]={1} ", i, dice);
            }
            Console.ReadLine();
        }
    }
}
