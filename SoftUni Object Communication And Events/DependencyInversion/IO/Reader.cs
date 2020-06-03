using System;

namespace DependencyInversion.IO
{
    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public string[] Split(string input)
        {
            return input.Split(' ');
        }
    }
}
