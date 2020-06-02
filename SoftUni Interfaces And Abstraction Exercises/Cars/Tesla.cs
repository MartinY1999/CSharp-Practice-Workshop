using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public string Model { get; set; }
        public string Colour { get; set; }
        public int Batteries { get; set; }
        public string Start()
        {
            return "Engine start";
        }
        public string Stop()
        {
            return "Breaak!";
        }
        public Tesla(string model, string colour, int batteries)
        {
            Model = model;
            Colour = colour;
            Batteries = batteries;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"{Colour} Tesla {Model} with {Batteries} Batteries")
                .AppendLine($"{this.Start()}")
                .AppendLine($"{this.Stop()}");
            return builder.ToString();
        }
    }
}
