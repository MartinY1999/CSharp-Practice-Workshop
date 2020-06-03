using SULS.Models;
using System.Collections.Generic;
using System.Linq;

namespace SULS.Services.Contracts
{
    public interface ISubmissionsService
    {
        void CreateSubmission(string problemId, string userId, string code);
        int CountOfSubmissionsForCurrentProblem(string problemId);
        IQueryable<Submission> ReturnSubmissionForCurrentProblem(string problemId);
        void Delete(string submissionId);
    }
}
