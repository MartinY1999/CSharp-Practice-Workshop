using System;
using System.Text;

namespace Ferrari
{
    public class Ferrari : ICarFunctionality
    {
        private string model = "488-Spider";
        public string Model => model;
        public string Name { get; private set; }
        public string Brakes()
        {
            return "Brakes!";
        }
        public string PushGas()
        {
            return "Zadu6avam sA!";
        }
        public Ferrari(string name)
        {
            Name = name;
        }
        public static Ferrari Create()
        {
            string name = Console.ReadLine();
            return new Ferrari(name);
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"{Model}/{this.Brakes()}/{this.PushGas()}/{Name}");
            return builder.ToString();
        }
    }
}
