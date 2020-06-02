using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace GroceryShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([A-Z][a-z]+:)(\d{1,}\.\d{2})$";
            Dictionary<string, string> prices = new Dictionary<string, string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "bill") break;
                else
                {
                    Match matched = Regex.Match(input, pattern);
                    if (matched.Success)
                    {
                        if (!prices.ContainsKey(matched.Groups[1].Value)) prices.Add(matched.Groups[1].Value, string.Empty);
                        prices[matched.Groups[1].Value] = matched.Groups[2].Value;
                    }
                }
            }

            foreach (KeyValuePair<string, string> pair in prices.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{pair.Key} costs {pair.Value}");
            }

            Console.ReadLine();
        }
    }
}
