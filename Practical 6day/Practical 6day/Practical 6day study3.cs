﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_6day
{
    class Practical_6day_study3
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> capital = new Dictionary<String, String>();
            capital["日本"] = "東京";
            capital["イギリス"] = "ロンドン";
            capital["フランス"] = "パリ";
            capital["中国"] = "北京";
            Console.WriteLine("世界の首都");
            foreach(String s in capital.Keys)
            {
                Console.WriteLine("{0}の首都は{1}です。", s, capital[s]);
            }
        }
    }
}
