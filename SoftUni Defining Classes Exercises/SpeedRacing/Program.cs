using System;
using System.Collections.Generic;

namespace SpeedRacing
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
                Car current = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));
                cars.Add(current);
            }
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input[0] == "End") break;
                else
                {
                    switch (input[0])
                    {
                        case "Drive":
                            string model = input[1];
                            int amountOfKm = int.Parse(input[2]);
                            int index = cars.FindIndex(x => x.Model == model);
                            if (Car.TryDrive(cars[index], amountOfKm)) continue;
                            else
                            {
                                Console.WriteLine("Insufficient fuel for the drive");
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
            Console.ReadLine();
        }
    }
}
