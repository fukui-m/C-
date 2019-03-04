using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _5day_test2
    {
        static void Main(string[] args)
        {
            int[] data = new int[4];
            double[] firstInputvalue = { 0.2, -5.1, 3.2, 1.8 };
            for(int i = 0; i < data.Length; i++)
            {
                Console.Write("d[{0}]={1} ", i, firstInputvalue[i]);
            }
            Console.ReadLine();
        }
    }
}
