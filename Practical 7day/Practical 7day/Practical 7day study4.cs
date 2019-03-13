using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7day
{
    class Practical_7day_study4
    {
        static int GetNum(int i)
        {
            int[] nums = { 300, 600, 900 };
            if (i > nums.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return nums[i];
        }
        static void Main()
        {
            try
            {
                int result = GetNum(4);
            }catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("配列の範囲外にアクセスしました。");
            }
        }
    }
}
