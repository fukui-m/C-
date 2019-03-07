using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_2day
{
    class Practical_2day_test4_2
    {
        private int count = 0;
        static int totalCount = 0;
        public static int TotalCount(int p1Count,int p2Count)
        {
            totalCount = p1Count + p2Count;
            return totalCount;
        }
        public void Reset()
        {
            count = 0;
        }
        public void Increment()
        {
            count++;
        }
        public int Count
        {
            get{
                return count;
            }
        }
    }
}
