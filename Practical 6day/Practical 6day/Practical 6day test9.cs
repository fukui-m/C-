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
            var numCalc = new List<string>();
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
            var numInputvalue = int.Parse(Console.ReadLine());
            var numCount = numInputvalue.ToString().Length;
            int numDigitsCalc,conmaCount= 0;
            int numDigits = 1;

            Console.Write("変換結果:");
            for (int i = 0; i < numCount; i++)
            {
                if (conmaCount==3 )
                {
                    numCalc.Add(",");
                    conmaCount = 0;
                }
                numDigits = numDigits * 10;
                numDigitsCalc = numInputvalue % numDigits;
                char numKey = numDigitsCalc.ToString()[0];
                numCalc.Add(numConvision[numKey.ToString()]);
                conmaCount++;
            }
            numCalc.Reverse();
            numCalc.ForEach(x => Console.Write("{0}", x));
            Console.ReadLine();
        }
    }
}


