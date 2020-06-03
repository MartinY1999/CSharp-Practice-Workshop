using System;
using InfernoInfinity.Controllers;

namespace InfernoInfinity
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Run();
            Console.ReadLine();
        }
    }
}
