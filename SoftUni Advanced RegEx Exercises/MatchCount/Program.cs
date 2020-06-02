using System;
using System.Text.RegularExpressions;

namespace MatchCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();
            MatchCollection matches = Regex.Matches(text, pattern);
            Console.WriteLine(matches.Count);
            Console.ReadLine();
        }
    }
}
