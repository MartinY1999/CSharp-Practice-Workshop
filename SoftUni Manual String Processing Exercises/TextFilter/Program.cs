using System;
using System.Linq;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banned = Console.ReadLine().Split(',').ToArray();
            string text = Console.ReadLine();
            foreach (string word in banned)
            {
                text = text.Replace(word.Trim(), new string('*', word.Trim().Length).ToString());
            }
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
