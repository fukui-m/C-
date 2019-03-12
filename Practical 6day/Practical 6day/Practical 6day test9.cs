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
            var numConvision = new Dictionary<String, String>();
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
            var numCount = numInputvalue.Length;
            numInputvalue.ToList();

            Console.Write("変換結果:");
            for(int i = 0;i< numCount; i++)
            {
                var numbers = numConvision.FirstOrDefault(x => x.key == numInputvalue);
                
                    Console.Write("{0}", numConvision[numInputvalue]);
                
            }
            Console.ReadLine();
        }
    }
}

