using AnimalCentre.Models.Base_Classes;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Child_Classes.ProcedureDerived
{
    public class Play : Procedure
    {
        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);
            animal.Energy -= 6;
            animal.Happiness += 12;
            base.procedureHistory.Add(animal);
        }
    }
}
