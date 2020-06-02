using System;
using System.Text.RegularExpressions;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = "[AEUOIYaeuoiy]";
            MatchCollection matches = Regex.Matches(text, pattern);
            Console.WriteLine($"Vowels: {matches.Count}");
            Console.ReadLine();
        }
    }
}
