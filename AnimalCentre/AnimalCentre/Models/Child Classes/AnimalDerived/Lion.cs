using AnimalCentre.Models.Base_Classes;

namespace AnimalCentre.Models.Child_Classes.AnimalDerived
{
    public class Lion : Animal
    {
        public Lion(string name, int energy, int happiness, int procedureTime) : base(name, energy, happiness, procedureTime)
        {
        }

        public override string ToString()
        {
            return
                $"Animal type: Lion - {this.Name} - Happiness: {this.Happiness} - Energy: {this.Energy}";
        }
    }
}
