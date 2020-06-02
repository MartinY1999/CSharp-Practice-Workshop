using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', '\\','/', ')', '(', '\t');
            List<string> usernames = new List<string>();
            foreach (string element in input)
            {
                string pattern = @"\b[a-zA-Z]\w{2,24}\b";
                Match m = Regex.Match(element, pattern);
                if (m.Success) usernames.Add(m.Value);
            }
            string max1 = string.Empty;
            string max2 = string.Empty;
            int maxLength = Int32.MinValue;
            for (int i = 1; i < usernames.Count; i++)
            {
                if (usernames[i - 1].Length + usernames[i].Length > maxLength)
                {
                    max1 = usernames[i - 1];
                    max2 = usernames[i];
                    maxLength = usernames[i - 1].Length + usernames[i].Length;
                }
            }
            Console.WriteLine(max1);
            Console.WriteLine(max2);
            Console.ReadLine();
        }
    }
}
