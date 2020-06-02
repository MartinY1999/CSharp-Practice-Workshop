using System;

namespace GenericCountMethodStrings
{
    public class Reader : IReader
    {
        public int ReadInt()
        {
            return int.Parse(Console.ReadLine());
        }

        public string ReadString()
        {
            return Console.ReadLine();
        }

        public double ReadDouble()
        {
            return double.Parse(Console.ReadLine());
        }
    }
}
