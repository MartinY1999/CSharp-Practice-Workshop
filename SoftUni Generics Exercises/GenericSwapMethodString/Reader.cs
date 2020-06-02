using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodString
{
    public class Reader : IReader
    {
        public string ReadString()
        {
            return Console.ReadLine();
        }

        public int ReadInt()
        {
            return int.Parse(Console.ReadLine());
        }

        public List<int> ReadCommand()
        {
            return Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToList();
        }

        public Box<string> ReadStringBox()
        {
            return new Box<string>(Console.ReadLine());
        }

        public Box<int> ReadIntBox()
        {
            return new Box<int>(int.Parse(Console.ReadLine()));
        }
    }
}
