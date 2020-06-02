using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            string map = Console.ReadLine();
            string hideout = string.Empty;
            while (true)
            {
                string[] minCount = Console.ReadLine().Split(' ');
                string keyWord = minCount[0];
                int count = int.Parse(minCount[1]);
                string pattern = $@"\{keyWord}{{{count},}}";
                try
                {
                    MatchCollection matches = Regex.Matches(map, pattern);
                    if (matches.Count != 0)
                    {
                        List<string> toList = matches.Cast<Match>().Select(Convert.ToString).ToList();
                        hideout = toList.OrderByDescending(x => x.Length).First();
                        goto Done;
                    }
                }
                catch
                {
                    continue;
                }
            }
            Done:;
            int index = map.IndexOf(hideout);
            Console.WriteLine($"Hideout found at index {index} and it is with size {hideout.Length}");
            Console.ReadLine();
        }
    }
}
