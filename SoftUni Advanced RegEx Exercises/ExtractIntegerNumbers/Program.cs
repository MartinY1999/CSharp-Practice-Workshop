using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(\-)?\d+";
            MatchCollection integers = Regex.Matches(text, pattern);
            integers.Cast<Match>().ToList().ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
