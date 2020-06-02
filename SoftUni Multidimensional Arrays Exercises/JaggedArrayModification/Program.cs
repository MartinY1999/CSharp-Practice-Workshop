using System;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[][] matrix = new int[N][];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END") break;
                else
                {
                    string[] parts = input.Split(' ');
                    int row = int.Parse(parts[1]);
                    int column = int.Parse(parts[2]);
                    int value = int.Parse(parts[3]);
                    switch (parts[0])
                    {
                        case "Add":
                            try
                            {
                                matrix[row][column] += value;
                            }
                            catch
                            {
                                Console.WriteLine("Invalid coordinates");
                            }
                            break;
                        case "Subtract":
                            try
                            {
                                matrix[row][column] -= value;
                            }
                            catch
                            {
                                Console.WriteLine("Invalid coordinates");
                            }
                            break;
                        default:
                            break;
                    }
                }
            }

            foreach (int[] row in matrix)
            {
                Console.WriteLine(String.Join(" ", row));
            }

            Console.ReadLine();
        }
    }
}
