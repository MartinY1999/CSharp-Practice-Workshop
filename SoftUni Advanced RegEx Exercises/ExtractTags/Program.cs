using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractTags
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"\<\/?.*?\>";
            while (true)
            {
                string text = Console.ReadLine();
                if (text == "END") break;
                else
                {
                    MatchCollection tags = Regex.Matches(text, pattern);
                    tags.Cast<Match>().ToList().ForEach(Console.WriteLine);
                }
            }
            Console.ReadLine();
        }
    }
}
