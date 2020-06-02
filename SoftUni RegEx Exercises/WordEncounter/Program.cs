using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordEncounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string filter = Console.ReadLine();
            char character = filter[0];
            int digit = Convert.ToInt32(Convert.ToString(filter[1]));
            string pattern = @"[A-Z].*?(\.|\!|\?)$";
            List<string> words = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end") break;
                else
                {
                    Match sentence = Regex.Match(input, pattern);
                    if (sentence.Success)
                    {
                        MatchCollection wrds = Regex.Matches(sentence.Value, @"\w+");
                        foreach (Match wrd in wrds)
                        {
                            char[] letters = wrd.Value.ToCharArray();
                            int counter = 0;
                            foreach (char l in letters)
                            {
                                if (l == character) counter++;
                            }
                            if (counter >= digit) words.Add(wrd.Value);
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(", ", words));
            Console.ReadLine();
        }
    }
}
