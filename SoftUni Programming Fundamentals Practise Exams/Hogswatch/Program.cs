using System;

namespace Hogswatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int homes = int.Parse(Console.ReadLine());
            int totalPresents = int.Parse(Console.ReadLine());
            int additionalPresents = 0;
            int timesBack = 0;
            int currentPresents = totalPresents;

            for (int i = 1; i <= homes; i++)
            {
                int presents = int.Parse(Console.ReadLine());
                if (presents <= currentPresents) currentPresents -= presents;
                else
                {
                    timesBack++;
                    int toAdd = totalPresents / i * (homes - i) + presents - currentPresents;
                    additionalPresents += toAdd;
                    currentPresents += toAdd - presents;
                }
            }

            if (timesBack == 0) Console.WriteLine(currentPresents);
            else
            {
                Console.WriteLine(timesBack);
                Console.WriteLine(additionalPresents);
            }

            Console.ReadLine();
        }
    }
}
