using System;
using Microsoft.Win32.SafeHandles;

namespace TheHeiganDance
{
    class Program
    {
        private static double playerHealth = 18500;
        private static double bossHealth = 3000000;

        static void Main(string[] args)
        {
            double damage = double.Parse(Console.ReadLine());
            char[,] chamber = new char[15, 15];
            Position current = new Position(7, 7);
            string killedBy = string.Empty;
            bool spellCloud = false;
            FillMatrix(ref chamber);
            int originalRow = 7;
            int originalColumn = 7;
            bool killedByCloud = false;
            bool killedByEruption = false;
            while (playerHealth > 0 && bossHealth >= 0)
            {
                bossHealth -= damage;
                string[] command =
                    Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                bool inDamageArea = DamageArea(chamber, command);
                if (spellCloud)
                {
                    playerHealth -= 3500;
                    spellCloud = false;
                    if (playerHealth <= 0)
                    {
                        killedByCloud = true;
                    }
                }
                if (inDamageArea)
                {
                    if (bossHealth > 0)
                    {
                        MovePlayer(chamber, current, originalRow, originalColumn);
                        if (current.Row == originalRow && current.Column == originalColumn)
                        {
                            switch (command[0])
                            {
                                case "Cloud":
                                    playerHealth -= 3500;
                                    spellCloud = true;
                                    if (playerHealth <= 0) killedByCloud = true;
                                    break;
                                case "Eruption":
                                    if (spellCloud)
                                    {
                                        playerHealth -= 3500;
                                        if (playerHealth <= 0) killedByCloud = true;
                                        spellCloud = false;
                                    }
                                    if (playerHealth > 0)
                                    {
                                        playerHealth -= 6000;
                                        if (playerHealth <= 0) killedByEruption = true;
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            originalRow = current.Row;
                            originalColumn = current.Column;
                        }
                    }
                }
                if (killedByCloud) killedBy = "Plague Cloud";
                else if (killedByEruption) killedBy = "Eruption";
                ReverseArea(chamber, command);
            }
            if (killedBy == string.Empty)
            {
                Console.WriteLine($"Heigan: Defeated!");
                Console.WriteLine($"Player: {playerHealth}");
                Console.WriteLine($"Final position: {current.Row}, {current.Column}");
            }
            else if (killedBy != string.Empty && bossHealth < 0)
            {
                Console.WriteLine($"Heigan: Defeated!");
                Console.WriteLine($"Player: Killed by {killedBy}");
                Console.WriteLine($"Final position: {current.Row}, {current.Column}");
            }
            else
            {
                Console.WriteLine($"Heigan: {bossHealth:F2}");
                Console.WriteLine($"Player: Killed by {killedBy}");
                Console.WriteLine($"Final position: {current.Row}, {current.Column}");
            }
            Console.ReadLine();
        }
        private static void MovePlayer(char[,] chamber, Position current, int row , int column)
        {
            TryMoveUp(chamber, current);
            if (row == current.Row && column == current.Column)
            {
                TryMoveRight(chamber, current);
                if (row == current.Row && column == current.Column)
                {
                    TryMoveDown(chamber, current);
                    if (row == current.Row && column == current.Column)
                    {
                        TryMoveLeft(chamber, current);
                    }
                }
            }
        }
        private static void TryMoveUp(char[,] chamber, Position current)
        {
            if (current.Row - 1 >= 0)
            {
                if (chamber[current.Row - 1, current.Column] != 'D')
                {
                    chamber[current.Row - 1, current.Column] = 'P';
                    chamber[current.Row, current.Column] = 'D';
                    current.Row -= 1;
                }
            }
        }
        private static void TryMoveRight(char[,] chamber, Position current)
        {
            if (current.Column + 1 < 15)
            {
                if (chamber[current.Row, current.Column + 1] != 'D')
                {
                    chamber[current.Row, current.Column + 1] = 'P';
                    chamber[current.Row, current.Column] = 'D';
                    current.Column += 1;
                }
            }
        }
        private static void TryMoveDown(char[,] chamber, Position current)
        {
            if (current.Row + 1 < 15)
            {
                if (chamber[current.Row + 1, current.Column] != 'D')
                {
                    chamber[current.Row + 1, current.Column] = 'P';
                    chamber[current.Row, current.Column] = 'D';
                    current.Row += 1;
                }
            }
        }
        private static void TryMoveLeft(char[,] chamber, Position current)
        {
            if (current.Column - 1 >= 0)
            {
                if (chamber[current.Row, current.Column - 1] != 'D')
                {
                    chamber[current.Row, current.Column - 1] = 'P';
                    chamber[current.Row, current.Column] = 'D';
                    current.Column -= 1;
                }
            }
        }
        private static void ReverseArea(char[,] chamber, string[] command)
        {
            int row = int.Parse(command[1]);
            int col = int.Parse(command[2]);
            int startRow = -1;
            int endRow = -1;
            int startCol = -1;
            int endCol = -1;

            if (row - 1 < 0) startRow = 0;
            else startRow = row - 1;
            if (row + 1 > 14) endRow = 14;
            else endRow = row + 1;

            if (col - 1 < 0) startCol = 0;
            else startCol = col - 1;
            if (col + 1 > 14) endCol = 14;
            else endCol = col + 1;

            for (int r = startRow; r <= endRow; r++)
            for (int c = startCol; c <= endCol; c++)
            {
                if (chamber[r, c] == 'D') chamber[r, c] = '.';
            }
        }
        private static bool DamageArea(char[,] chamber, string[] command)
        {
            int row = int.Parse(command[1]);
            int col = int.Parse(command[2]);
            bool inDamage = false;
            int startRow = -1;
            int endRow = -1;
            int startCol = -1;
            int endCol = -1;

            if (row - 1 < 0) startRow = 0;
            else startRow = row - 1;
            if (row + 1 > 14) endRow = 14;
            else endRow = row + 1;

            if (col - 1 < 0) startCol = 0;
            else startCol = col - 1;
            if (col + 1 > 14) endCol = 14;
            else endCol = col + 1;

            for (int r = startRow; r <= endRow; r++)
            for (int c = startCol; c <= endCol; c++)
            {
                if (chamber[r, c] == 'P') inDamage = true;
                else chamber[r, c] = 'D';
            }
            return inDamage;
        }
        private static void FillMatrix(ref char[,] chamber)
        {
            for (int row = 0; row < 15; row++)
            for (int column = 0; column < 15; column++)
            {
                if (row == 7 && column == 7) chamber[row, column] = 'P';
                else chamber[row, column] = '.';
            }
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
