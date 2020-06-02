using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            IVehicle car = Car.Create();
            IVehicle truck = Truck.Create();
            IVehicle bus = Bus.Create();
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                try
                {
                    DoCommands(car, truck, bus);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    continue;
                }
            }
            car.Print();
            truck.Print();
            bus.Print();
            Console.ReadLine();
        }
        private static void DoCommands(IVehicle car, IVehicle truck, IVehicle bus)
        {
            ICollection<string> parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double litres = double.Parse(parts.ElementAt(2));
            switch (parts.ElementAt(1))
            {
                case "Car":
                    if (parts.ElementAt(0) == "Drive")
                        car.Drive(litres);
                    else
                        car.Refuel(litres);
                    break;
                case "Truck":
                    if (parts.ElementAt(0) == "Drive")
                        truck.Drive(litres);
                    else
                        truck.Refuel(litres);
                    break;
                case "Bus":
                    Bus current = bus as Bus;
                    if (parts.ElementAt(0) == "Drive")
                        current?.Drive(litres);
                    else if (parts.ElementAt(0) == "DriveEmpty")
                        current?.DriveEmpty(litres);
                    else
                        current?.Refuel(litres);
                    break;
                default:
                    break;
            }
        }
    }
}
