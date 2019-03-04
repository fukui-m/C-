using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _5day_test8
    {
        static void Main(string[] args)
        {
            int[] data = { 0, 1, 2, 3, 4 };
            Random rnd = new Random();
            var Largecount= 0;
            var Smallcount = 0;
            var zerothcount = 0;
            for(int i = 0; i< data.Length; i++)
            {
                int dice = rnd.Next(-10, 11);
                Console.Write("{0} ", dice);
                if (0 < dice)
                {
                    Largecount++;
                }else if (dice < 0)
                {
                    Smallcount++;
                }else if (dice == 0)
                {
                    zerothcount++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("0より大きい数:{0}個", Largecount);
            Console.WriteLine("0より小さい数:{0}個", Smallcount);
            Console.WriteLine("0の個数:{0}", zerothcount);
            Console.ReadLine();
            }
    }
}
