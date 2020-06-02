using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        private string model;
        private string power;
        private string displacement = "n/a";
        private string efficienty = "n/a";
        public string Model
        {
            get => this.model;
            set => this.model = value;
        }
        public string Power
        {
            get => this.power;
            set => this.power = value;
        }
        public string Displacement
        {
            get => this.displacement;
            set => this.displacement = value;
        }
        public string Efficiency
        {
            get => this.efficienty;
            set => this.efficienty = value;
        }
        public Engine (string m, string p) : this(m, p, "n/a", "n/a") { }
        public Engine(string m, string p, string d) : this(m, p, d, "n/a") { }
        public Engine(string m, string p, string d, string e)
        {
            Model = m;
            Power = p;
            Displacement = d;
            Efficiency = e;
        }
        public static Engine CreateEngine(string[] input)
        {
            if (input.Length == 2) return new Engine(input[0], input[1]);
            else if (input.Length == 3)
            {
                int value;
                if (!int.TryParse(input[2], out value)) return new Engine(input[0], input[1], "n/a", input[2]);
                return new Engine(input[0], input[1], input[2]);
            }
            else return new Engine(input[0], input[1], input[2], input[3]);
        }
    }
}
