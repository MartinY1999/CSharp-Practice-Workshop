using SULS.Models;

namespace SULS.Services.Contracts
{
    public interface IProblemsService
    {
        Problem CreateProblem(Problem problem);
        Problem ReturnCurrentProblem(string id);
    }
}
