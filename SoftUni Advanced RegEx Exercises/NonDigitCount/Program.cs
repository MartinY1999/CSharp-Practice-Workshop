using System;
using System.Text.RegularExpressions;

namespace NonDigitCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            MatchCollection nonDigits = Regex.Matches(text, @"\D");
            Console.WriteLine($"Non-digits: {nonDigits.Count}");
            Console.ReadLine();
        }
    }
}
