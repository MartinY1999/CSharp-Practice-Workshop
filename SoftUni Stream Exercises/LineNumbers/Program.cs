using System;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose a file path: ");
            string filePath = Console.ReadLine();
            using (StreamReader reader = new StreamReader(filePath))
            {
                using (StreamWriter writer = new StreamWriter("../../result.txt"))
                {
                    int writerNumber = 1;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine($"{writerNumber}.{line}");
                        writerNumber++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
