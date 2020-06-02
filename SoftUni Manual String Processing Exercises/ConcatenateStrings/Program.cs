using System;
using System.Text;

namespace ConcatenateStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            for (int i = 1; i <= N; i++)
            {
                string input = Console.ReadLine();
                text.Append($"{input} ");
            }
            Console.WriteLine(text.ToString());
            Console.ReadLine();
        }
    }
}
