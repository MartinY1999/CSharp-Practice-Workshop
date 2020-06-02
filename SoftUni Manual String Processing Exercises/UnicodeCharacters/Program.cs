using System;
using System.Collections.Generic;
using System.Text;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string code = Console.ReadLine();
            List<StringBuilder> builded = new List<StringBuilder>();
            foreach (char letter in code)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(@"\u");
                sb.Append(String.Format("{0:x4}", (int)letter));
                builded.Add(sb);
            }
            builded.ForEach(Console.Write);
            Console.ReadLine();
        }
    }
}
