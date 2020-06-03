using System;
using TrafficLights.Models;

namespace TrafficLights.Controllers
{
    public class Engine
    {
        public void Run()
        {
            try
            {
                TrafficLight tl = Creator.CreateTrafficLight();
                int N = int.Parse(Console.ReadLine());
                for (int i = 1; i <= N; i++)
                {
                    tl.Shift();
                    Console.WriteLine(tl);
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
