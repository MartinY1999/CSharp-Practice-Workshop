using System;
using System.Linq;

namespace SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine(String.Join(", ", numbers.Where(x => x % 2 == 0).OrderBy(x => x)));
            Console.ReadLine();
        }
    }
}
