using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string sequence = Console.ReadLine();
            string pattern = @"\|<\w+";
            List<string> views = new List<string>();
            MatchCollection matches = Regex.Matches(sequence, pattern);
            foreach (Match m in matches)
            {
                char[] view = m.Value.ToCharArray();
                string result = String.Join("", view.Skip(array[0] + 2).Take(array[1]));
                views.Add(result);
            }
            Console.WriteLine(String.Join(", ", views));
        }
    }
}
