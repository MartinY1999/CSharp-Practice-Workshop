using System;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../oddlines.txt"))
            {
                int lineNumber = 0;
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line != null)
                    {
                        if (lineNumber % 2 != 0) Console.WriteLine(line);
                        lineNumber++;
                    }
                    else break;
                }
            }
            Console.ReadLine();
        }
    }
}
