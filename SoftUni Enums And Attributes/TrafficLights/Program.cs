using System;
using TrafficLights.Controllers;

namespace TrafficLights
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
