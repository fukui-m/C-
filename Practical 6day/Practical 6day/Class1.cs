using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_6day
{
    class Class1
    {
        static void Main(string[] args)
        {
            var numList = GenerateRandomNumbers().ToList();
            numList.ForEach(x => Console.WriteLine("0～100の値を出力:{0}", x.ToString()));


            Enumerable.Range(0, 10)
                .ToList()
                .ForEach(num => Console.WriteLine("一の位が{0}:", num.ToString()));
            numList.ForEach(x => Console.Write("{0}}", numList.Select(y => y % 10 == 1)));

            Console.ReadLine();
        }

        static Random rnd = new Random();
        static IEnumerable<int> GenerateRandomNumbers()
        {
            while (true)
            {
                var num = rnd.Next(0, 101);
                yield return num;

                if (num == 0) break;
            }
        }
    }
}
