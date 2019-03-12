using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_6day
{
    class Practical_6day_test9
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> numConvision = new Dictionary<String, String>();
            numConvision["1"] = "一";
            numConvision["2"] = "二";
            numConvision["3"] = "三";
            numConvision["4"] = "四";
            numConvision["5"] = "五";
            numConvision["6"] = "六";
            numConvision["7"] = "七";
            numConvision["8"] = "八";
            numConvision["9"] = "九";
            numConvision["0"] = "○";
            Console.Write("整数の値を入力してください:");
            var numInputvalue = Console.ReadLine();

            Console.Write("変換結果:");
            if (numConvision.Keys.Any(x => x == numInputvalue))
            {
                Console.Write("{0}", numConvision[numInputvalue]);
            }
        }
    }
}

