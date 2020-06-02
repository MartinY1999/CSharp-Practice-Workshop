using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ShmoogleCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> doubles = new List<string>();
            List<string> ints = new List<string>();
            string doublesPattern = @"\bdouble\s([a-z](\w+)?)\b";
            string intsPattern = @"\bint\s([a-z](\w+)?)\b";
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "//END_OF_CODE") break;
                else
                {
                    input = input.TrimStart();
                    MatchCollection m = Regex.Matches(input, doublesPattern);
                    foreach (Match match in m)
                        doubles.Add(match.Groups[1].Value);
                    MatchCollection p = Regex.Matches(input, intsPattern);
                    foreach (Match match in p)
                        ints.Add(match.Groups[1].Value);
                }
            }
            doubles = doubles.OrderBy(x => x).ToList();
            ints = ints.OrderBy(x => x).ToList();
            Console.WriteLine((doubles.Count != 0) ? $"Doubles: {String.Join(", ", doubles)}" : $"Doubles: None");
            Console.WriteLine((ints.Count != 0) ? $"Ints: {String.Join(", ", ints)}" : "Ints: None");
            Console.ReadLine();
        }
    }
}
