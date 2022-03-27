﻿using System;
using System.Globalization;

namespace SelfCSharp.Chap05
{
    class TimeExact
    {
        static void Main(string[] args)
        {
            var str = "20180215131723";
            DateTime dt = DateTime.ParseExact(str, "yyyyMMddHHmmss",
                new CultureInfo("ja-JP"));

            //var formats = new[] { "yyyyMMddHHmmss", "yyyy/MM/dd HHmmss" };
            //DateTime dt = DateTime.ParseExact(str, formats,
            //    new CultureInfo("ja-JP"), DateTimeStyles.None);

            Console.WriteLine(dt);
        }
    }
}