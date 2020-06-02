using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([^&=?]*)=([^&=]*)";
            while (true)
            {
                Dictionary<string, List<string>> fiendValue = new Dictionary<string, List<string>>();
                string input = Console.ReadLine();
                if (input == "END") break;
                else
                {
                    Regex pairs = new Regex(pattern);
                    MatchCollection matches = pairs.Matches(input);
                    string[] queryStrings = matches.Cast<Match>().Select(Convert.ToString).ToArray();
                    List<string> correct = new List<string>();
                    for (int i = 0; i < queryStrings.Length; i++)
                    {
                        if (queryStrings[i].Contains("+")) queryStrings[i] = queryStrings[i].Replace("+", " ");
                        if (queryStrings[i].Contains("%20")) queryStrings[i] = queryStrings[i].Replace("%20", " ");
                        correct.Add(queryStrings[i]);
                    }
                    for (int l = 0; l < correct.Count; l++)
                    {
                        string[] splitParts = correct[l].Split('=');
                        string fiend = splitParts[0].Trim();
                        string value = splitParts[1].Trim();
                        Regex r = new Regex(@"\s+");
                        fiend = r.Replace(fiend, " ");
                        value = r.Replace(value, " ");
                        if (!fiendValue.ContainsKey(fiend)) fiendValue.Add(fiend, new List<string>());
                        fiendValue[fiend].Add(value);
                    }
                    PrintResult(fiendValue);
                }
            }
            Console.ReadLine();
        }
        static void PrintResult(Dictionary<string, List<string>> fiendValue)
        {
            foreach (KeyValuePair<string, List<string>> pair in fiendValue)
            {
                Console.Write($"{pair.Key}=[{String.Join(", ", pair.Value)}]");
            }
            Console.WriteLine();
        }
    }
}
