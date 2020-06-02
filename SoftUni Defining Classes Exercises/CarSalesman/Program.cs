using System;
using System.Collections.Generic;

namespace CarSalesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                engines.Add(Engine.CreateEngine(input));
            }
            int M = int.Parse(Console.ReadLine());
            for (int i = 1; i <= M; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                int index = engines.FindIndex(x => x.Model == input[1]);
                cars.Add(Car.CreateCar(input, engines[index]));
            }
            foreach (Car vehicle in cars)
            {
                Car.PrintResult(vehicle);
            }
            Console.ReadLine();
        }
    }
}
