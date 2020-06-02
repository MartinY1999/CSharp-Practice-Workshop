using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();
            char[] delimiters = {'.', '!', '?'};
            string[] sentences = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            foreach (string sentence in sentences)
            {
                string pattern = $@"\b{keyword}\b";
                Match matched = Regex.Match(sentence, pattern);
                if (matched.Success) Console.WriteLine(sentence.Trim());
            }
        }
    }
}
