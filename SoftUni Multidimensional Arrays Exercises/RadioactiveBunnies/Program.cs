using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO.MemoryMappedFiles;
using System.Linq;

namespace RadioactiveBunnies
{
    class Program
    {
        public static int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        static void Main(string[] args)
        {
            char[][] matrix = new char[numbers[0]][];
            for (int row = 0; row < numbers[0]; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();
            }
            char[] commands = Console.ReadLine().ToCharArray();
            Status status = new Status(string.Empty, -1, -1);
            foreach (char command in commands)
            {
                switch (command)
                {
                    case 'U':
                        status = Up(matrix, status);
                        break;
                    case 'D':
                        status = Down(matrix, status);
                        break;
                    case 'L':
                        status = Left(matrix, status);
                        break;
                    case 'R':
                        status = Right(matrix, status);
                        break;
                    default:
                        break;
                }
                status = SpreadBunnies(ref matrix, status);
                if (status.WL == "won" || status.WL == "dead")
                {
                    PrintData(matrix, status);
                    goto Done;
                }
            }
            Done:;
            Console.ReadLine();
        }
        private static void PrintData(char[][] matrix, Status status)
        {
            foreach (char[] row in matrix)
            {
                Console.WriteLine(String.Join("", row));
            }
            Console.Write($"{(status.WL == "won" ? "won" : "dead")}: {status.Row} {status.Column}");
        }
        private static Status SpreadBunnies(ref char[][] matrix, Status status)
        {
            List<Indexes> indexes = new List<Indexes>();
            for (int y = 0; y < numbers[0]; y++)
            {
                for (int x = 0; x < numbers[1]; x++)
                {
                    if (matrix[y][x] == 'B') indexes.Add(new Indexes(y, x));
                }
            }
            foreach (Indexes index in indexes)
            {
                if (index.Row > 0 && matrix[index.Row][index.Column] == 'B')
                {
                    if (matrix[index.Row - 1][index.Column] == 'P')
                    {
                        status.WL = "dead";
                        status.Row = index.Row - 1;
                        status.Column = index.Column;
                    }
                    matrix[index.Row - 1][index.Column] = 'B';
                }
                if (index.Row < numbers[0] - 1 && matrix[index.Row][index.Column] == 'B')
                {
                    if (matrix[index.Row + 1][index.Column] == 'P')
                    {
                        status.WL = "dead";
                        status.Row = index.Row + 1;
                        status.Column = index.Column;
                    }
                    matrix[index.Row + 1][index.Column] = 'B';
                }
                if (index.Column > 0 && matrix[index.Row][index.Column] == 'B')
                {
                    if (matrix[index.Row][index.Column - 1] == 'P')
                    {
                        status.WL = "dead";
                        status.Row = index.Row;
                        status.Column = index.Column - 1;
                    }
                    matrix[index.Row][index.Column - 1] = 'B';
                }
                if (index.Column < numbers[1] - 1 && matrix[index.Row][index.Column] == 'B')
                {
                    if (matrix[index.Row][index.Column + 1] == 'P')
                    {
                        status.WL = "dead";
                        status.Row = index.Row;
                        status.Column = index.Column + 1;
                    }
                    matrix[index.Row][index.Column + 1] = 'B';
                }
            }
            return status;
        }
        private static Status Up(char[][] matrix, Status status)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                if (matrix[row].Contains('P'))
                {
                    int index = matrix[row].ToList().IndexOf('P');
                    try
                    {
                        if (matrix[row - 1][index] == '.')
                        {
                            matrix[row - 1][index] = 'P';
                            matrix[row][index] = '.';
                            break;
                        }
                        else
                        {
                            matrix[row][index] = '.';
                            status.WL = "dead";
                            status.Row = row - 1;
                            status.Column = index;
                            break;
                        }
                    }
                    catch
                    {
                        matrix[row][index] = '.';
                        status.WL = "won";
                        status.Row = row;
                        status.Column = index;
                        break;
                    }
                }
            }
            return status;
        }
        private static Status Down(char[][] matrix, Status status)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                if (matrix[row].Contains('P'))
                {
                    int index = matrix[row].ToList().IndexOf('P');
                    try
                    {
                        if (matrix[row + 1][index] == '.')
                        {
                            matrix[row + 1][index] = 'P';
                            matrix[row][index] = '.';
                        }
                        else
                        {
                            matrix[row][index] = '.';
                            status.WL = "dead";
                            status.Row = row + 1;
                            status.Column = index;
                        }
                    }
                    catch
                    {
                        matrix[row][index] = '.';
                        status.WL = "won";
                        status.Row = row;
                        status.Column = index;
                    }
                }
            }
            return status;
        }
        private static Status Left(char[][] matrix, Status status)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                if (matrix[row].Contains('P'))
                {
                    int index = matrix[row].ToList().IndexOf('P');
                    try
                    {
                        if (matrix[row][index - 1] == '.')
                        {
                            matrix[row][index - 1] = 'P';
                            matrix[row][index] = '.';
                        }
                        else
                        {
                            matrix[row][index] = '.';
                            status.WL = "dead";
                            status.Row = row;
                            status.Column = index - 1;
                            
                        }
                    }
                    catch
                    {
                        matrix[row][index] = '.';
                        status.WL = "won";
                        status.Row = row;
                        status.Column = index;
                    }
                }
            }
            return status;
        }
        private static Status Right(char[][] matrix, Status status)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                if (matrix[row].Contains('P'))
                {
                    int index = matrix[row].ToList().IndexOf('P');
                    try
                    {
                        if (matrix[row][index + 1] == '.')
                        {
                            matrix[row][index + 1] = 'P';
                            matrix[row][index] = '.';
                        }
                        else
                        {
                            matrix[row][index] = '.';
                            status.WL = "dead";
                            status.Row = row;
                            status.Column = index + 1;
                        }
                    }
                    catch
                    {
                        matrix[row][index] = '.';
                        status.WL = "won";
                        status.Row = row;
                        status.Column = index;
                    }
                }
            }
            return status;
        }
    }
    class Status
    {
        public string WL { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public Status(string w, int r, int c)
        {
            WL = w;
            Row = r;
            Column = c;
        }
    }
    class Indexes
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public Indexes(int r, int c)
        {
            Row = r;
            Column = c;
        }
    }
}
