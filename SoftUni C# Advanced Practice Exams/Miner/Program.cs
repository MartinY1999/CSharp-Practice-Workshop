using System;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(' ');
            char[][] matrix = new char[size][];
            Position player = new Position(-1, -1);
            for (int row = 0; row < size; row++)
            {
                matrix[row] = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 's')
                    {
                        player = new Position(row, col);
                        break;
                    }
                }
            }
            int collected = 0;
            int allCoals = GetCoals(matrix);
            bool dead = false;
            foreach (string command in commands)
            {
                switch (command)
                {
                    case "up":
                        if (player.Row - 1 >= 0)
                        {
                            matrix[player.Row][player.Column] = '*';
                            if (matrix[player.Row - 1][player.Column] == '*')
                            {
                                matrix[player.Row - 1][player.Column] = 's';
                                player = new Position(player.Row - 1, player.Column);
                            }
                            else if (matrix[player.Row - 1][player.Column] == 'c')
                            {
                                collected++;
                                allCoals--;
                                matrix[player.Row - 1][player.Column] = 's';
                                player = new Position(player.Row - 1, player.Column);
                            }
                            else if (matrix[player.Row - 1][player.Column] == 'e')
                            {
                                Console.WriteLine($"Game over! ({player.Row - 1}, {player.Column})");
                                dead = true;
                                goto Done;
                            }
                        }
                        break;
                    case "right":
                        if (player.Column + 1 < size)
                        {
                            matrix[player.Row][player.Column] = '*';
                            if (matrix[player.Row][player.Column + 1] == '*')
                            {
                                matrix[player.Row][player.Column + 1] = 's';
                                player = new Position(player.Row, player.Column + 1);
                            }
                            else if (matrix[player.Row][player.Column + 1] == 'c')
                            {
                                collected++;
                                allCoals--;
                                matrix[player.Row][player.Column + 1] = 's';
                                player = new Position(player.Row, player.Column + 1);
                            }
                            else if (matrix[player.Row][player.Column + 1] == 'e')
                            {
                                Console.WriteLine($"Game over! ({player.Row}, {player.Column + 1})");
                                dead = true;
                                goto Done;
                            }
                        }
                        break;
                    case "down":
                        if (player.Row + 1 < size)
                        {
                            matrix[player.Row][player.Column] = '*';
                            if (matrix[player.Row + 1][player.Column] == '*')
                            {
                                matrix[player.Row + 1][player.Column] = 's';
                                player = new Position(player.Row + 1, player.Column);
                            }
                            else if (matrix[player.Row + 1][player.Column] == 'c')
                            {
                                collected++;
                                allCoals--;
                                matrix[player.Row + 1][player.Column] = 's';
                                player = new Position(player.Row + 1, player.Column);
                            }
                            else if (matrix[player.Row + 1][player.Column] == 'e')
                            {
                                Console.WriteLine($"Game over! ({player.Row + 1}, {player.Column})");
                                dead = true;
                                goto Done;
                            }
                        }
                        break;
                    case "left":
                        if (player.Column - 1 >= 0)
                        {
                            matrix[player.Row][player.Column] = '*';
                            if (matrix[player.Row ][player.Column - 1] == '*')
                            {
                                matrix[player.Row][player.Column - 1] = 's';
                                player = new Position(player.Row, player.Column - 1);
                            }
                            else if (matrix[player.Row][player.Column - 1] == 'c')
                            {
                                collected++;
                                allCoals--;
                                matrix[player.Row][player.Column - 1] = 's';
                                player = new Position(player.Row, player.Column - 1);
                            }
                            else if (matrix[player.Row][player.Column - 1] == 'e')
                            {
                                Console.WriteLine($"Game over! ({player.Row}, {player.Column - 1})");
                                dead = true;
                                goto Done;
                            }
                        }
                        break;
                }
            }
            Done: ;
            if (!dead)
            {
                if (allCoals == 0) Console.WriteLine($"You collected all coals! ({player.Row}, {player.Column})");
                else Console.WriteLine($"{allCoals} coals left. ({player.Row}, {player.Column})");
            }
            Console.ReadLine();
        }
        private static int GetCoals(char[][] matrix)
        {
            int coals = 0;
            foreach (char[] row in matrix)
            {
                foreach (char symbol in row)
                {
                    if (symbol == 'c') coals++;
                }
            }
            return coals;
        }
    }
    class Position
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Position(int row, int col)
        {
            Row = row;
            Column = col;
        }
    }
}
