using System;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Base_Classes
{
    public abstract class Animal : IAnimal
    {
        private int happiness;
        private int energy;
        private string owner = "Centre";
        public string Name { get; }

        public int Happiness
        {
            get => happiness;
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Invalid happiness");
                happiness = value;
            }
        }

        public int Energy
        {
            get => energy;
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Invalid energy");
                energy = value;
            }
        }
        public int ProcedureTime { get; set; }

        public string Owner
        {
            get => owner;
            set
            {
                owner = value;
            }
        }

        public bool IsAdopt { get; set; }
        public bool IsChipped { get; set; }
        public bool IsVaccinated { get; set; }

        public Animal(string name, int energy, int happiness, int procedureTime)
        {
            this.Name = name;
            this.Energy = energy;
            this.Happiness = happiness;
            this.ProcedureTime = procedureTime;
        }
    }
}
