using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end") break;
                else
                {
                    Match current = Regex.Match(input, pattern);
                    if (current.Length != 0)
                    {
                        string newPattern = $@"[URL href={current.Groups[1].Value}]{current.Groups[2].Value}[/URL]";
                        string replacement = Regex.Replace(input, pattern, newPattern, RegexOptions.IgnoreCase);
                        data.Add(replacement);
                    }
                    else data.Add(input);
                }
            }
            data.ForEach(Console.WriteLine);
        }
    }
}
