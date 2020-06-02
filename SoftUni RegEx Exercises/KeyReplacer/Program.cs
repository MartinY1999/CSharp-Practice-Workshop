using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyString = Console.ReadLine();
            string text = Console.ReadLine();

            string getRemovevablePartPatt = @"\b[\|</]\w+[\|</]?";
            string toRemove = Regex.Match(keyString, getRemovevablePartPatt).Value;
            keyString = keyString.Replace(toRemove, " ");
            string[] keyWords = keyString.Split(' ');

            string start = keyWords[0];
            string end = keyWords[1];

            string lastPattern = $@"{start}(?<word>.*?){end}";
            MatchCollection matches = Regex.Matches(text, lastPattern);
            StringBuilder result = new StringBuilder();
            foreach (Match m in matches)
            {
                result.Append(m.Groups["word"].Value);
            }
            if (result.Length == 0) Console.WriteLine("Empty result");
            else Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }
}
