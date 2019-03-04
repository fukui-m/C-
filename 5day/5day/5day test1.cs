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
            int []data = new int[7];
            Random rnd = new Random();
            
            for (int i = 0;i < data.Length; i++){
                int dice = rnd.Next(1, 11);
                Console.Write("a[{0}]={1} ", i, dice);
            }
            Console.ReadLine();
        }
    }
}
