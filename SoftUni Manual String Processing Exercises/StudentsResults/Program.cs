using System;

namespace StudentsResults
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("{0, 10}|{1, 7}|{2, 7}|{3,7}|{4,7}", "Name", "CAdv", "COOP", "AdvOOP",
                "Average"));
            for (int i = 1; i <= N; i++)
            {
                string[] words = Console.ReadLine().Split(new char[] { ' ', '-', ','}, StringSplitOptions.RemoveEmptyEntries);
                double average = (double.Parse(words[1]) + double.Parse(words[2]) + double.Parse(words[3])) / 3;
                Console.WriteLine(string.Format("{0, 10}|{1, 7:F2}|{2, 7:F2}|{3,7:F2}|{4,7:F4}", words[0],
                    double.Parse(words[1]), double.Parse(words[2]), double.Parse(words[3]),
                    average));
            }
            Console.ReadLine();
        }
    }
}
