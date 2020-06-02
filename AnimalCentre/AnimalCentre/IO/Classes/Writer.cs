using System;
using System.Text;
using AnimalCentre.IO.Contracts;

namespace AnimalCentre.IO.Classes
{
    public class Writer : IWriter
    {
        private StringBuilder sb;

        public Writer()
        {
            this.sb = new StringBuilder();
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public void Flush()
        {
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
