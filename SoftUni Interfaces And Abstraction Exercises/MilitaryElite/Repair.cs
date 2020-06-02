using System;

namespace MilitaryElite
{
    public class Repair
    {
        private string part;
        public string Part
        {
            get => part;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("");
                part = value;
            }
        }
        public int Hours { get; private set; }
        public Repair(string part, int hours)
        {
            Part = part;
            Hours = hours;
        }
        public static Repair Create(string part, string hours)
        {
            int value;
            if (int.TryParse(hours, out value))
                return new Repair(part, int.Parse(hours));
            else
                throw new ArgumentException("");
        }
        public override string ToString()
        {
            return $"Part Name: {this.Part} Hours Worked: {this.Hours}";
        }
    }
}
