using System;

namespace CountSubstringOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            int occurences = 0;
            string words = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();
            int index = words.IndexOf(word);
            while (index != -1)
            {
                occurences++;
                index = words.IndexOf(word, index + 1);
            }
            Console.WriteLine(occurences);
            Console.ReadLine();
        }
    }
}
