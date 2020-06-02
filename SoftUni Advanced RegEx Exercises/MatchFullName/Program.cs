using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"(\b[A-Z][a-z]+)( )([A-Z][a-z]+\b)");
            MatchCollection matches = pattern.Matches(input);
            foreach (Match m in matches)
            {
                Console.Write($"{m} ");
            }
            Console.ReadLine();
        }
    }
}
