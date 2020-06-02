using AnimalCentre.Models.Base_Classes;

namespace AnimalCentre.Models.Child_Classes.AnimalDerived
{
    public class Cat : Animal
    {
        public Cat(string name, int energy, int happiness, int procedureTime) : base(name, energy, happiness, procedureTime)
        {
        }

        public override string ToString()
        {
            return
                $"Animal type: Cat - {this.Name} - Happiness: {this.Happiness} - Energy: {this.Energy}";
        }
    }
}
