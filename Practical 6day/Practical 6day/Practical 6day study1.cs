﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_6day
{
    class Practical_6day_study1
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            a.Add(3);
            a.Add(2);
            a.Add(1);
            a.Insert(1, 4);
            for(int i = 0; i < a.Count; i++)
            {
                Console.WriteLine("a[{0}]={1}", i, a[i]);
            }
        }
    }
}
