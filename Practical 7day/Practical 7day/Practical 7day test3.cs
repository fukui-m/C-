using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7day
{
    class Practical_7day_test3
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 1, 2 };
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("a[" + i + "]=" + a[i]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("配列の範囲を超えています。");
            }
            Console.ReadLine();
        }
    }
}

