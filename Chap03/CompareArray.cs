using System;
using System.Linq;

namespace SelfCSharp.Chap03
{
    class CompareArray
    {
        static void Main(string[] args)
        {
            var data1 = new[] { "い", "ろ", "は" };
            var data2 = new[] { "い", "ろ", "は" };
            Console.WriteLine(data1 == data2); // 結果:false
            Console.WriteLine(data1.Equals(data2)); // 結果:false
            Console.WriteLine(data1.SequenceEqual(data2)); // 結果:true
        }
    }
}