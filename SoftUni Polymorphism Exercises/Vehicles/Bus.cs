using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicles
{
    public class Bus : IVehicle
    {
        public double FuelQuantity { get; private set; }
        public double FuelConsumption { get; private set; }
        public double TankCapacity { get; }
        public Bus(double capacity, double fuel, double litresPerKm)
        {
            TankCapacity = capacity;
            FuelQuantity = fuel > capacity ? 0 : fuel;
            FuelConsumption = litresPerKm;
        }
        public static Bus Create()
        {
            ICollection<string> parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return new Bus(double.Parse(parts.ElementAt(3)),
                double.Parse(parts.ElementAt(1)), double.Parse(parts.ElementAt(2)));
        }
        public void Drive(double distance)
        {
            this.FuelConsumption += 1.4;
            if (this.FuelQuantity - distance * this.FuelConsumption >= 0)
            {
                this.FuelQuantity -= distance * this.FuelConsumption;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
                Console.WriteLine("Bus needs refueling");

            this.FuelConsumption -= 1.4;
        }
        public void DriveEmpty(double distance)
        {
            if (this.FuelQuantity - distance * this.FuelConsumption >= 0)
            {
                this.FuelQuantity -= distance * this.FuelConsumption;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
                Console.WriteLine("Bus needs refueling");
        }
        public void Refuel(double fuel)
        {
            if (fuel > this.TankCapacity)
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            else if (fuel <= 0)
                throw new ArgumentException($"Fuel must be a positive number");
            this.FuelQuantity += 0.95 * fuel;
        }
        public override string ToString()
        {
            return $"Bus: {this.FuelQuantity:F2}";
        }
        public void Print()
        {
            Console.WriteLine(this);
        }
    }
}
