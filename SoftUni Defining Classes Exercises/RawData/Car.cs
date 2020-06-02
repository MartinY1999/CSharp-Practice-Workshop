using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tire> Tires { get; set; }
        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }
        public static Car Create(string[] input)
        {
            return new Car(input[0], new Engine(int.Parse(input[1]), int.Parse(input[2])),
                new Cargo(int.Parse(input[3]), input[4]), new List<Tire>());
        }
        public override string ToString()
        {
            return $"{Model}";
        }
    }
}
