using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace SemanticHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern1 = @"\<div.*?id\s*=\s*\""(.*?)\"".*?\>";
            string pattern2 = @"\<\/div\>.*?\<\!\-{1,}(.*?)\-{1,}\>";
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END") break;
                else
                {
                    Match m1 = Regex.Match(line, pattern1);
                    Match m2 = Regex.Match(line, pattern2);
                    if (m1.Success) Console.WriteLine($"<{m1.Groups[1].Value.Trim()}>");
                    else if (m2.Success) Console.WriteLine($"</{m2.Groups[1].Value.Trim()}>");
                    else continue;
                }
            }
            Console.ReadLine();
        }
    }
}
