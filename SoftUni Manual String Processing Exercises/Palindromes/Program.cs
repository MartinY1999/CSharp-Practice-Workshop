using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> palindromes = new List<string>();
            char[] delimiters = { ',', ' ', '.', '!', '?' };
            List<string> words = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (string word in words)
            {
                StringBuilder reversed = new StringBuilder();
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversed.Append(word[i]);
                }
                if (reversed.ToString() == word) palindromes.Add(word);
            }
            Console.WriteLine(String.Join(", ", palindromes.OrderBy(x => x).Distinct()));
            Console.ReadLine();
        }
    }
}
