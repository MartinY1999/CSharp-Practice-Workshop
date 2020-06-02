using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }
        public Car(string model, Engine engine) :this(model, engine, "n/a", "n/a") { }
        public Car(string model, Engine engine, string weight) :this(model, engine, weight, "n/a") { }
        public Car(string model, Engine engine, string weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }
        public static Car CreateCar(string[] input, Engine current)
        {
            if (input.Length == 2) return new Car(input[0], current);
            else if (input.Length == 3)
            {
                int value;
                if (!int.TryParse(input[2], out value)) return new Car(input[0], current, "n/a", input[2]);
                else return new Car(input[0], current, input[2]);
            }
            else return new Car(input[0], current, input[2], input[3]);
        }
        public static void PrintResult(Car currentCar)
        {
            Console.WriteLine($"{currentCar.Model}:");
            Console.WriteLine($"  {currentCar.Engine.Model}:");
            Console.WriteLine($"    Power: {currentCar.Engine.Power}");
            Console.WriteLine($"    Displacement: {currentCar.Engine.Displacement}");
            Console.WriteLine($"    Efficiency: {currentCar.Engine.Efficiency}");
            Console.WriteLine($"  Weight: {currentCar.Weight}");
            Console.WriteLine($"  Color: {currentCar.Color}");
        }
    }
}
