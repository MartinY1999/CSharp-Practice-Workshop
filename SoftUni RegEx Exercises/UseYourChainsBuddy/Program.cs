using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UseYourChainsBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(?<=<p>).*?(?=</p>)";
            MatchCollection matches = Regex.Matches(text, pattern);
            List<string> data = matches.Cast<Match>().Select(Convert.ToString).ToList();
            for (int i = 0; i < data.Count; i++)
            {
                Regex r = new Regex(@"[^0-9a-z]+");
                data[i] = r.Replace(data[i], " ");
                char[] letters = data[i].ToCharArray();
                for (int l = 0; l < letters.Length; l++)
                {
                    if (letters[l] >= 'a' && letters[l] <= 'm') letters[l] = Convert.ToChar(Convert.ToInt32(letters[l]) + 13);
                    else if (letters[l] >= 'n' && letters[l] <= 'z') letters[l] = Convert.ToChar(Convert.ToInt32(letters[l]) - 13);
                }
                Console.Write(String.Join("", letters));
            }
            Console.ReadLine();
        }
    }
}
