using System;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int totalTimePerHour = employee1 + employee2 + employee3;
            int students = int.Parse(Console.ReadLine());
            int time = 0;

            while (students > 0)
            {
                time++;
                students -= totalTimePerHour;
                if (time % 4 == 0 && time >= 4) time++;
            }
            Console.WriteLine($"Time needed: {time}h.");
            Console.ReadLine();
        }
    }
}
