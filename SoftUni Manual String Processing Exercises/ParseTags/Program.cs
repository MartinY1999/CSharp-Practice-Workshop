using System;
using System.Text.RegularExpressions;

namespace ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = "<upcase>.*?</upcase>";
            MatchCollection ms = Regex.Matches(text, pattern);
            foreach (Match m in ms)
            {
                string upperCase = m.Value.Substring(8, m.Value.Length - 17).ToUpper();
                text = text.Replace(m.Value, upperCase);
            }
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
