using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BoomingCannon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dc = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int distance = dc[0];
            int count = dc[1];
            string pattern = @"(?:\\<<<)(\w+)";
            string input = Console.ReadLine();
            List<string> results = new List<string>();
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match m in matches)
            {
                string result = String.Join("", m.Groups[1].Value.Skip(distance).Take(count));
                results.Add(result);
            }

            Console.WriteLine(String.Join("/\\", results));
            Console.ReadLine();
        }
    }
}
