﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4day
{
    class _4day_study2
    {
        static void Main(string[] args)
        {
            for (int i= 1; i <= 2; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    int k = i + j;
                    Console.Write(i + "+" + j + "=" + k + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
