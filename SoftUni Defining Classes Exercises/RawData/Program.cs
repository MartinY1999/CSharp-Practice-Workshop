using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 1; i <= N; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                Car current = Car.Create(input);
                List<Tire> currentTires = new List<Tire>();
                for (int k = 5; k < input.Length; k += 2)
                {
                    Tire newTire = new Tire(double.Parse(input[k]), Int32.Parse(input[k + 1]));
                    currentTires.Add(newTire);
                }
                current.Tires.AddRange(currentTires);
                cars.Add(current);
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                cars = cars.Where(x => x.Cargo.Type == command).ToList();
                cars = cars.Where(x => x.Tires.Any(k => k.Pressure < 1)).ToList();
                foreach (Car car in cars)
                    Console.WriteLine(car);
            }
            else if (command == "flamable")
            {
                cars = cars.Where(x => x.Cargo.Type == command).ToList();
                cars = cars.Where(x => x.Engine.Power > 250).ToList();
                foreach (Car car in cars)
                    Console.WriteLine(car);
            }
            Console.ReadLine();
        }
    }
}
