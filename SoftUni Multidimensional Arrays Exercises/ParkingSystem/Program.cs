using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingSystem
{
    class Program
    {
        private static int[] RC = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        static void Main(string[] args)
        {
            char[][] lot = new char[RC[0]][];
            for (int row = 0; row < RC[0]; row++)
            {
                lot[row] = new string('.', RC[1]).ToCharArray();
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "stop") break;
                else
                {
                    int[] numbers = command.Split(' ').Select(int.Parse).ToArray();
                    int counter = 0;
                    int entryRow = numbers[0];
                    int desiredRow = numbers[1];
                    int desiredColumn = numbers[2];
                    if (lot[desiredRow].Skip(1).Any(x => x == '.'))
                    {
                        if (lot[desiredRow][desiredColumn] == '.')
                        {
                            counter += Math.Abs(desiredRow - entryRow) + 1 + desiredColumn;
                            Console.WriteLine(counter);
                            lot[desiredRow][desiredColumn] = 'C';
                        }
                        else
                        {
                            int indexCol = GetNearestFreeCol(lot, desiredRow, desiredColumn);
                            counter += Math.Abs(desiredRow - entryRow) + 1 + indexCol;
                            Console.WriteLine(counter);
                            lot[desiredRow][indexCol] = 'C';
                        }
                    }
                    else Console.WriteLine($"Row {desiredRow} full");
                }
            }
            Console.ReadLine();
        }
        private static int GetNearestFreeCol(char[][] parking, int parkRow, int parkCol)
        {
            for (int i = 1; i < parking[parkRow].Length; i++)
            {
                if (parkCol > i && parking[parkRow][parkCol - i] != 'C')
                    return parkCol - i;
                if (parkCol + i < parking[parkRow].Length && parking[parkRow][parkCol + i] != 'C')
                    return parkCol + i;
            }
            return -1;
        }
    }
}
