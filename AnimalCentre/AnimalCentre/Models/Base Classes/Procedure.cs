using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Base_Classes
{
    public abstract class Procedure : IProcedure
    {
        protected IList<IAnimal> procedureHistory;

        public Procedure()
        {
            this.procedureHistory = new List<IAnimal>();
        }

        public string History()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.GetType().Name);
            IList<string> animalsInfo = this.procedureHistory
                .OrderBy(a => a.Name)
                .Select(a => a.ToString())
                .ToArray();
            foreach (string animal in animalsInfo)
            {
                sb.AppendLine($"    {animal}");
            }
            string result = sb.ToString().TrimEnd();
            return result;
        }

        public virtual void DoService(IAnimal animal, int procedureTime)
        {
            if (animal.ProcedureTime < procedureTime)
                throw new ArgumentException($"Animal doesn't have enough procedure time");
            animal.ProcedureTime -= procedureTime;
        }
    }
}
