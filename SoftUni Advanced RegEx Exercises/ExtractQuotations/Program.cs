using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractQuotations
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            MatchCollection quotations = Regex.Matches(text, @"(\'(.*?)\')|(\""(.*?)\"")");
            foreach (Match quote in quotations)
            {
                Console.WriteLine(quote.Value.Substring(1, quote.Value.Length - 2));
            }
            Console.ReadLine();
        }
    }
}
