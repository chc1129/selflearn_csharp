using System;

namespace SelfCSharp.Chap05
{
    class StrSubstring
    {
        static void Main(string[] args)
        {
            var str = "WINGSプロジェクト";
            Console.WriteLine(str.Substring(5, 2)); // 結果:プロ

            var path = @"C:\data\wings.jpg";
            Console.WriteLine(path.Substring(path.LastIndexOf(".") + 1)); // 結果:jpg
            Console.WriteLine(path[0]); // 結果:C

        }
    }
}