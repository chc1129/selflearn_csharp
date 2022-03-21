using System;

namespace SelfCSharp.Chap03
{
    class Increment
    {
        static void Main(string[] args)
        {
            var m = 3;
            var n = ++m;
            Console.WriteLine(m); // 結果:4
            Console.WriteLine(n); // 結果:4

            var m2 = 3;
            var n2 = m2++;
            Console.WriteLine(m2); // 結果:4
            Console.WriteLine(n2); // 結果:3
        }
    }
}
