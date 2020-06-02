using System;
using System.Linq;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            decimal sum = 0;
            for (int i = 0; i < words.Length; i++)
            {
                decimal currentResult = GetResult(words[i]);
                sum += currentResult;
            }
            Console.WriteLine($"{sum:F2}");
            Console.ReadLine();

        }
        static decimal GetResult(string v)
        {

            int leftIndex = (int)(v.First()) % 32;
            int rightIndex = (int)(v.Last()) % 32;
            int number = Convert.ToInt32(v.Substring(1, v.Length - 2));
            decimal result = 0;
            if (char.IsUpper(v.First())) result = (decimal)number / leftIndex;
            else result = number * leftIndex;
            if (char.IsUpper(v.Last())) result -= rightIndex;
            else result += rightIndex;
            return result;
        }
    }
}
