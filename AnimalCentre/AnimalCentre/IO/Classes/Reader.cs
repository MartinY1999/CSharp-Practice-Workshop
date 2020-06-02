using System;
using AnimalCentre.IO.Contracts;

namespace AnimalCentre.IO.Classes
{
    public class Reader : IReader
    {
        public string ReadData()
        {
            return Console.ReadLine();
        }
    }
}
