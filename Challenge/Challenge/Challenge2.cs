using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class Challenge2
    {
        static void Main(string[] args)
        {
            int minInputValue = 1;
            int maxInputValue = 100;
            int matchNumberCount = 0;
            Console.WriteLine("a*a+b*b=c*cの条件を満たす組み合わせ");
            for (int a = minInputValue; a <= maxInputValue; a++)
            {
                for (int b = minInputValue; b <= maxInputValue; b++)
                {
                    for (int c = minInputValue; c <= maxInputValue; c++)
                    {
                        if (a * a + b * b == c * c&&a<b)
                        {
                            Console.WriteLine("a={0} b={1} c={2}", a, b, c);
                            matchNumberCount++;
                        }
                    }
                }
            }
            Console.WriteLine("上記の組み合わせの合計：{0}", matchNumberCount);
            Console.ReadLine();
        }
    }
}
