using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OnlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\d+)([A-Za-z])";
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match gr in matches)
            {
                string number = gr.Groups[1].Value;
                string letter = gr.Groups[2].Value;
                input = input.Replace(number, letter);
            }
            Console.WriteLine(input);
            Console.ReadLine();
        }
    }
}
