using System;
using System.Text.RegularExpressions;

namespace ExtractHyperlinks
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern =
                @"(?:<a)(?:[\s\n_0-9a-zA-Z=""()]*?.*?)(?:href([\s\n]*)?=(?:['""\s\n]*)?)([a-zA-Z:#\/._\-0-9!?=^+]*(\([""'a-zA-Z\s.()0-9]*\))?)(?:[\s\na-zA-Z=""()0-9]*.*?)?(?:\>)";
            while (true)
            {
                string text = Console.ReadLine();
                if (text == "END") break;
                else
                {
                    MatchCollection ms = Regex.Matches(text, pattern);
                    foreach (Match m in ms)
                    {
                        Console.WriteLine(m.Groups[2].Value);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
