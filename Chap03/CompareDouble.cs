﻿using System;

namespace SelfCSharp.Chap03
{
    class CompareDouble
    {
        static void Main(string[] args)
        {
            const double EPSILON = 0.00001;
            double x = 0.2 * 3;
            double y = 0.6;
            Console.WriteLine(Math.Abs(x - y) < EPSILON); // 結果:true
        }
    }
}