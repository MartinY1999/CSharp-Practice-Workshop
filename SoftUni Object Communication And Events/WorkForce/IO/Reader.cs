using System;

namespace WorkForce.IO
{
    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public string[] Split(string input)
        {
            return input.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
