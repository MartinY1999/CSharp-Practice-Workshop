using System;
using InfernoInfinity.Interfaces;

namespace InfernoInfinity.IO
{
    public class Reader : IReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}
