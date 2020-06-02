using System;
using System.Text;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder reversed = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }
            Console.WriteLine(reversed.ToString());
            Console.ReadLine();
        }
    }
}
