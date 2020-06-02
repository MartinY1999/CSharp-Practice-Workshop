using System;
using AnimalCentre.Models.Base_Classes;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Child_Classes.ProcedureDerived
{
    public class NailTrim : Procedure
    {
        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);
            animal.Happiness -= 7;
            base.procedureHistory.Add(animal);
        }
    }
}
