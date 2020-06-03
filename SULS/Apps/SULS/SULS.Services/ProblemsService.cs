using SULS.Data;
using SULS.Models;
using SULS.Services.Contracts;
using System.Linq;

namespace SULS.Services
{
    public class ProblemsService : IProblemsService
    {
        private readonly SULSContext database;

        public ProblemsService(SULSContext database)
        {
            this.database = database;
        }

        public Problem CreateProblem(Problem problem)
        {
            this.database.Add(problem);
            this.database.SaveChanges();

            return problem;
        }

        public Problem ReturnCurrentProblem(string id)
        {
            return this.database.Problems.FirstOrDefault(x => x.Id == id);
        }
    }
}
