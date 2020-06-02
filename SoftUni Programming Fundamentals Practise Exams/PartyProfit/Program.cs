using System;

namespace PartyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int totalCoins = 0;
            for (int i = 1; i <= days; i++)
            {
                if (i % 10 == 0 && i % 15 != 0) size -= 2;
                else if (i % 10 != 0 && i % 15 == 0) size += 5;
                else if (i % 10 == 0 && i % 15 == 0) size += 3;
                if (i % 3 == 0 && i % 5 == 0) totalCoins = totalCoins + 50  + 13 * size;
                else if (i % 3 == 0 && i % 5 != 0) totalCoins = totalCoins + 50 - 5 * size;
                else if (i % 3 != 0 && i % 5 == 0) totalCoins = totalCoins + 50 + 18 * size;
                else totalCoins = totalCoins + 50 - 2 * size;
            }

            Console.WriteLine($"{size} companions received {totalCoins / size} coins each");
            Console.ReadLine();
        }
    }
}
