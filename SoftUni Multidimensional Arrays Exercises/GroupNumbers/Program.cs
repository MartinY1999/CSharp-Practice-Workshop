using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            int[] numbers = Console.ReadLine().Split(new string[] {", "}
                ,StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            for (int i = 0; i < 3; i++)
            {
                List<int> current = new List<int>();
                foreach (int num in numbers)
                {
                    if (Math.Abs(num) % 3 == i) current.Add(num);
                }
                matrix[i] = current.ToArray();
            }
            foreach (int[] row in matrix)
            {
                Console.WriteLine(String.Join(" ", row));
            }
            Console.ReadLine();
        }
    }
}
