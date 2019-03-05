using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7day
{
    class _7day_test2
    {
        static void Main(string[] args)
        {
            _7day_test2_2 s = new _7day_test2_2();

            s.GetConnectedString = s.String1 + s.String2;
            Console.WriteLine("一つ目の文字列は" + s.String1);
            Console.WriteLine("二つ目の文字列は" + s.String2);
            Console.WriteLine("二つの文字列を合成したものは" + s.GetConnectedString);
            Console.ReadLine();
        }
    }
}
