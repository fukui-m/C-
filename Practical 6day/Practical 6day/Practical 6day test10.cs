using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_6day
{
    class Practical_6day_test10
    {
        static void Main(string[] args)
        {
            HashSet<int> numList = new HashSet<int>();
            Random rnd = new Random();
            int dice = 0;
            Console.Write("乱数:");
            for(int i = 0; i < 10; i++)
            {
                dice = rnd.Next(1, 11);
                Console.Write("{0} ", dice);
                numList.Add(dice);
            }
            Console.WriteLine("");
            Console.Write("出現した数:");
            var orederdedNumList=numList.OrderBy(x => x);

            foreach (int i in orederdedNumList)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
