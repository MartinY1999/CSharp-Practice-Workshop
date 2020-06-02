using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmailStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string pattern = @"^([A-Za-z]{5,})(@)([a-z]{3,})(\.com|\.bg|\.org)$";
            Dictionary<string, List<string>> links = new Dictionary<string, List<string>>();
            for (int i = 1; i <= N; i++)
            {
                string input = Console.ReadLine();
                Match matched = Regex.Match(input, pattern);
                if (matched.Success)
                {
                    string username = matched.Groups[1].Value;
                    string domain = matched.Groups[3].Value + matched.Groups[4].Value;
                    if (!links.ContainsKey(domain)) links.Add(domain, new List<string>());
                    if (links[domain].Any(x => x == username) == false) links[domain].Add(username);
                }
            }
            foreach (var pair in links.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{pair.Key}:");
                foreach (string username in pair.Value)
                {
                    Console.WriteLine($"### {username}");
                }
            }
            Console.ReadLine();
        }
    }
}
