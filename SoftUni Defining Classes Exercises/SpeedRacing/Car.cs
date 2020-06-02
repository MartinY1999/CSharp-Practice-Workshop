using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }
        public double Fuel { get; set; }
        public double Consumption { get; set; }
        public int DistanceTravelled = 0;
        public Car(string model, double fuel, double consumption)
        {
            Model = model;
            Fuel = fuel;
            Consumption = consumption;
        }
        public static bool TryDrive(Car car, int kms)
        {
            if (car.Fuel >= car.Consumption * kms)
            {
                car.Fuel -= car.Consumption * kms;
                car.DistanceTravelled += kms;
                return true;
            }
            else return false;
        }
        public override string ToString()
        {
            return $"{Model} {Fuel:F2} {DistanceTravelled}";
        }
    }
}
