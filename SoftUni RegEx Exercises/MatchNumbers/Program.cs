using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(^|(?<=\s))-?[0-9]+(\.[0-9]+)?($|(?=\s))");
            string input = Console.ReadLine();
            MatchCollection numbers = pattern.Matches(input);
            Console.WriteLine(String.Join(" ", numbers.Cast<Match>().ToList()));
            Console.ReadLine();
        }
    }
}
