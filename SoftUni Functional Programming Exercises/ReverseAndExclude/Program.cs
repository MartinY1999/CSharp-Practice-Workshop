using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int divider = int.Parse(Console.ReadLine());
            numbers.Reverse();
            numbers.RemoveAll(x => Math.Abs(x) % divider == 0);
            Console.WriteLine(String.Join(" ", numbers));
            Console.ReadLine();
        }
    }
}
