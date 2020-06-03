using System;
using InfernoInfinity.Interfaces;

namespace InfernoInfinity.IO
{
    public class Writer<T> : IWriter<T>
    {
        public void WriteLine(T text) => Console.WriteLine(text);
    }
}
