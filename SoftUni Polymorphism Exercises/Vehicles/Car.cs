using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Vehicles
{
    public class Car : IVehicle
    {
        private double fuelConsPerKm;
        public double FuelQuantity { get; private set; }
        public double FuelConsumption
        {
            get => fuelConsPerKm;
            private set
            {
                fuelConsPerKm = value + 0.9;
            }
        }
        public double TankCapacity { get; }
        public Car(double capacity, double fuel, double litresPerKm)
        {
            TankCapacity = capacity;
            FuelQuantity = fuel > capacity ? 0 : fuel;
            FuelConsumption = litresPerKm;
        }
        public static Car Create()
        {
            ICollection<string> parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return new Car(double.Parse(parts.ElementAt(3)), double.Parse(parts.ElementAt(1)),
                double.Parse(parts.ElementAt(2)));
        }
        public void Drive(double distance)
        {
            if (this.FuelQuantity - distance * this.FuelConsumption >= 0)
            {
                this.FuelQuantity -= distance * this.FuelConsumption;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
                Console.WriteLine("Car needs refueling");
        }
        public void Refuel(double fuel)
        {
            if (fuel > this.TankCapacity)
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            else if (fuel <= 0)
                throw new ArgumentException($"Fuel must be a positive number");
            this.FuelQuantity += fuel;
        }
        public override string ToString()
        {
            return $"Car: {this.FuelQuantity:F2}";
        }
        public void Print()
        {
            Console.WriteLine(this);
        }
    }
}
