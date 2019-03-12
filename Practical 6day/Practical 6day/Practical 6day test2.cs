using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_6day
{
    class Practical_6day_test2
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();
            Random rnd = new Random();
            int dice = 0;
            do
            {
                dice = rnd.Next(0, 11);
                Console.WriteLine("0～10の値を出力:{0}",dice);
                if (0 < dice)
                {
                    numList.Add(dice);
                }
            } while (dice > 0);
            Console.WriteLine("");
            numList.Reverse();
            foreach(int n in numList)
            {
                Console.Write(n+" ");
            }
            Console.ReadLine();
            
        }
    }
}
