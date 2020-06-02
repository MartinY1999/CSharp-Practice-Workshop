using System;
using System.Linq;
using System.Numerics;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger result = 0;
            string[] words = Console.ReadLine().Split(' ');
            string word1 = words[0];
            string word2 = words[1];
            string min = string.Empty;
            string max = string.Empty;
            if (word1.Length <= word2.Length)
            {
                min = word1;
                max = word2;
            }
            else
            {
                min = word2;
                max = word1;
            }
            while (min.Length > 0)
            {
                result += Convert.ToInt32(Convert.ToChar(min.ElementAt(0))) * Convert.ToInt32(Convert.ToChar(max.ElementAt(0)));
                min = min.Remove(0, 1);
                max = max.Remove(0, 1);
            }
            foreach (char left in max)
            {
                result += Convert.ToInt32(left);
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
