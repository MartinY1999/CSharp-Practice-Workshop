using System;
using System.Linq;
using TrafficLights.Enums;
using TrafficLights.Models;

namespace TrafficLights.Controllers
{
    public static class Creator
    {
        public static TrafficLight CreateTrafficLight()
        {
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (!ValidateParts(parts))
                throw new ArgumentException("Wrong colors");
            return new TrafficLight(parts[0], parts[1], parts[2]);
        }

        private static bool ValidateParts(string[] parts)
        {
            if (parts.All(x => Enum.GetNames(typeof(LightColors)).Contains(x)))
                return true;
            return false;
        }
    }
}
