using System;
using AnimalCentre.Models.Base_Classes;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Child_Classes.ProcedureDerived
{
    public class Fitness : Procedure
    {

        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);
            animal.Happiness -= 3;
            animal.Energy += 10;
            base.procedureHistory.Add(animal);
        }
    }
}
