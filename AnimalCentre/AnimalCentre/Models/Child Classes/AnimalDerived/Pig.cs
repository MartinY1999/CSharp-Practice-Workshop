using AnimalCentre.Models.Base_Classes;

namespace AnimalCentre.Models.Child_Classes.AnimalDerived
{
    public class Pig : Animal
    {
        public Pig(string name, int energy, int happiness, int procedureTime) : base(name, energy, happiness, procedureTime)
        {
        }

        public override string ToString()
        {
            return
                $"Animal type: Pig - {this.Name} - Happiness: {this.Happiness} - Energy: {this.Energy}";
        }
    }
}
