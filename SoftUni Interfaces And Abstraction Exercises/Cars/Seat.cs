using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public string Model { get; set; }
        public string Colour { get; set; }
        public Seat(string model, string colour)
        {
            Model = model;
            Colour = colour;
        }
        public string Start()
        {
            return "Engine start";
        }
        public string Stop()
        {
            return "Breaak!";
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"{Colour} Seat {Model}")
                .AppendLine($"{this.Start()}")
                .AppendLine($"{this.Stop()}");
            return builder.ToString().TrimEnd();
        }
    }
}
