using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> reverse = new Stack<int>(numbers);
            List<int> reversed = new List<int>();
            int length = numbers.Length;
            while (length > 0)
            {
                reversed.Add(reverse.Pop());
                length--;
            }
            Console.WriteLine(String.Join(" ", reversed));
            Console.ReadLine();
        }
    }
}
