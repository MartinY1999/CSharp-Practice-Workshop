using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MorseCodeUpgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            string zeroesPattern = @"0+";
            string onesPattern = @"1+";
            StringBuilder result = new StringBuilder();
            foreach (string element in input)
            {
                int sum = 0;
                MatchCollection zeroes = Regex.Matches(element, zeroesPattern);
                MatchCollection ones = Regex.Matches(element, onesPattern);
                foreach (Match zero in zeroes)
                {
                    if (zero.Value.Length == 1) sum += 3;
                    else sum += 4 * zero.Value.Length;
                }
                foreach (Match one in ones)
                {
                    if (one.Value.Length == 1) sum += 5;
                    else sum += 6 * one.Value.Length;
                }
                result.Append(Convert.ToChar(sum));
            }
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }
}
