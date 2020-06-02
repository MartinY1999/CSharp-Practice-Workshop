using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicles
{
    public class Truck : IVehicle
    {
        private double fuelPerKM;
        public double FuelQuantity { get; private set; }
        public double FuelConsumption
        {
            get => fuelPerKM;
            private set
            {
                fuelPerKM = value + 1.6;
            }
        }
        public double TankCapacity { get; }
        public Truck(double capacity, double fuel, double litresPerKm)
        {
            TankCapacity = capacity;
            FuelQuantity = fuel > capacity ? 0 : fuel;
            FuelConsumption = litresPerKm;
        }
        public static Truck Create()
        {
            ICollection<string> parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return new Truck(double.Parse(parts.ElementAt(3)),
                double.Parse(parts.ElementAt(1)), double.Parse(parts.ElementAt(2)));
        }
        public void Drive(double distance)
        {
            if (this.FuelQuantity - distance * this.FuelConsumption >= 0)
            {
                this.FuelQuantity -= distance * this.FuelConsumption;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
                Console.WriteLine("Truck needs refueling");
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
            return $"Truck: {this.FuelQuantity:F2}";
        }
        public void Print()
        {
            Console.WriteLine(this);
        }
    }
}
