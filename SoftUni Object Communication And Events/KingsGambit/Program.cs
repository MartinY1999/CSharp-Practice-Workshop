using System;
using System.Diagnostics;

namespace KingsGambit
{
    public class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Run();
            Console.ReadLine();
        }
    }
}
