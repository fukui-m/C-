using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6day
{
    class _6day_test1_2
    {
        public int Max(int a,int b ,int c,int maxInputValue)
        {
            int[] numlist = { a, b, c };
            for(int i = 0; i < numlist.Length; i++)
            {
                if (maxInputValue < numlist[i])
                {
                    maxInputValue = numlist[i];
                }
            }
            return maxInputValue;

        }

        public int Min(int a,int b,int c,int minInputValue)
        {
            int[] numlist = { a, b, c };
            for(int i = 0; i < numlist.Length; i++)
            {
                if (numlist[i] < minInputValue)
                {
                    minInputValue = numlist[i];
                }
            }
            return minInputValue;
        }
    }
}
