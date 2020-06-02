using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] parts = Console.ReadLine().Split('|');
            string firstPartPattern = @"(?<=([\#|\$\%\*\&]))([A-Z]+)(?=\1)";
            string secondPatPattern = @"(\d{2}):(\d{2})";
            Dictionary<char, int> capitalLetters = new Dictionary<char, int>();
            List<string> words = new List<string>();

            Match m = Regex.Match(parts[0], firstPartPattern);
            foreach (char letter in m.Value)
            {
                if (!capitalLetters.ContainsKey(letter)) capitalLetters.Add(letter, 0);
            }

            MatchCollection numbers = Regex.Matches(parts[1], secondPatPattern);
            foreach (Match num in numbers)
            {
                if (capitalLetters.Any(x => x.Key == Convert.ToChar(Convert.ToInt32(num.Groups[1].Value))))
                    capitalLetters[Convert.ToChar(Convert.ToInt32(num.Groups[1].Value))] =
                        Convert.ToInt32(num.Groups[1].Value);
            }

            foreach (KeyValuePair<char, int> pair in capitalLetters)
            {
                int index = numbers.Cast<Match>().ToList()
                    .FindIndex(x => Convert.ToInt32(x.Groups[1].Value) == pair.Value);
                int length = Convert.ToInt32(numbers.Cast<Match>().ToList()[index].Groups[2].Value);
                string pattern = $@"\b{pair.Key}\S{{{length}}}\b";
                Match wrd = Regex.Match(parts[2], pattern);
                if (wrd.Success)
                {
                    StringBuilder word = new StringBuilder();
                    string sPattern = @"([A-Z]\S+-)([A-Z]\S+)";
                    Match prts = Regex.Match(wrd.Value, sPattern);
                    if (prts.Success)
                    {
                        for (int i = 1; i < prts.Groups.Count; i++)
                        {
                            string capLetter = String.Join("", prts.Groups[i].Value.Take(1));
                            string lowLetters = String.Join("", prts.Groups[i].Value.Skip(1).Take(prts.Groups[i].Value.Length - 1));
                            lowLetters = lowLetters.ToLower();
                            word.Append(capLetter);
                            word.Append(lowLetters);
                        }
                    }
                    else
                    {
                        string capLetter = String.Join("", wrd.Value.Take(1));
                        string lowLetters = String.Join("", wrd.Value.Skip(1).Take(wrd.Value.Length - 1));
                        lowLetters = lowLetters.ToLower();
                        word.Append(capLetter);
                        word.Append(lowLetters);
                    }
                    words.Add(word.ToString());
                }
            }

            words.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
