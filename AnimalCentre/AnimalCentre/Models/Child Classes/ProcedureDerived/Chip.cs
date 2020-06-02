using System;
using System.Text;
using AnimalCentre.Models.Base_Classes;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Child_Classes.ProcedureDerived
{
    public class Chip : Procedure
    {

        public override void DoService(IAnimal animal, int procedureTime)
        {
            if (!animal.IsChipped)
            {
                base.DoService(animal, procedureTime);
                animal.Happiness-= 5;
                animal.IsChipped = true;
                base.procedureHistory.Add(animal);
            }
            else
                throw new ArgumentException($"{animal.Name} is already chipped");
        }
    }
}
