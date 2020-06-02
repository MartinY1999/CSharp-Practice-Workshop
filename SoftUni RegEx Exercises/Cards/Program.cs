using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(2|3|4|5|6|7|8|9|10|J|Q|K|A)(S|H|D|C)";
            MatchCollection cards = Regex.Matches(input, pattern);
            Console.WriteLine(String.Join(", ", cards.Cast<Match>().Select(Convert.ToString).ToList()));
            Console.ReadLine();
        }
    }
}
