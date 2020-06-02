using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> brackets = new Stack<int>();
            char[] array = input.ToCharArray();
            List<string> results = new List<string>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '(') brackets.Push(i);
                if (array[i] == ')')
                {
                    int index = brackets.Pop();
                    StringBuilder build = new StringBuilder();
                    build.Append(array[index]);
                    build.Append(String.Join("", input.Skip(index  + 1).Take(i - index - 1)));
                    build.Append(array[i]);
                    results.Add(build.ToString());
                }
            }
            foreach (string el in results)
            {
                Console.WriteLine(el);
            }
            Console.ReadLine();
        }
    }
}
