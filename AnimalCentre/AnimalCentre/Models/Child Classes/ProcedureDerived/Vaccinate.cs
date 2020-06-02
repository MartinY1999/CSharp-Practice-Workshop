using AnimalCentre.Models.Base_Classes;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Child_Classes.ProcedureDerived
{
    public class Vaccinate : Procedure
    {
        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);
            animal.Energy -= 8;
            animal.IsVaccinated = true;
            base.procedureHistory.Add(animal);
        }
    }
}
