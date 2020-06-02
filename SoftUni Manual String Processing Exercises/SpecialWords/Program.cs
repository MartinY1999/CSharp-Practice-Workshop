using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SpecialWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string pattern = $"{word}";
                MatchCollection ms = Regex.Matches(text, pattern);
                if (!counts.ContainsKey(word)) counts.Add(word, ms.Count);
                else counts[word] += ms.Count;
            }
            foreach (KeyValuePair<string, int> pair in counts.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
            Console.ReadLine();
        }
    }
}
