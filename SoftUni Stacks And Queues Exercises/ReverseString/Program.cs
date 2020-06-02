using System;
using System.Collections.Generic;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reversed = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                reversed.Push(input[i]);
            }
            foreach (char symbol in input)
            {
                Console.Write(reversed.Pop());
            }
            Console.ReadLine();
        }
    }
}
