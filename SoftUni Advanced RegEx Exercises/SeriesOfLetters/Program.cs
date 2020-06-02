using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder letters = new StringBuilder();
            char let = text.First();
            letters.Append(let);
            for (int i = 1; i < text.Length; i++)
            {
                if (let == text[i]) continue;
                else
                {
                    let = text[i];
                    letters.Append(let);
                }
            }
            Console.WriteLine(letters.ToString());
            Console.ReadLine();
        }
    }
}
