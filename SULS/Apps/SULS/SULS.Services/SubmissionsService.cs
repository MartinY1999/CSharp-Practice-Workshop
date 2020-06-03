using SULS.Data;
using SULS.Models;
using SULS.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SULS.Services
{
    public class SubmissionsService : ISubmissionsService
    {
        private readonly SULSContext database;

        public SubmissionsService(SULSContext database)
        {
            this.database = database;
        }

        public int CountOfSubmissionsForCurrentProblem(string problemId)
        {
            return this.database.Submissions.Where(x => x.ProblemId == problemId).Count();
        }

        public void CreateSubmission(string problemId, string userId, string code)
        {
            Problem problem = this.database.Problems.FirstOrDefault(p => p.Id == problemId);

            Submission submission = new Submission()
            {
                Code = code,
                AchievedResult = new Random().Next(0, problem.Points),
                CreatedOn = DateTime.UtcNow,
                ProblemId = problemId,
                UserId = userId
            };

            this.database.Add(submission);
            this.database.SaveChanges();
        }

        public void Delete(string submissionId)
        {
            Submission submissionToRemove = this.database.Submissions.FirstOrDefault(x => x.Id == submissionId);
            this.database.Submissions.Remove(submissionToRemove);
            this.database.SaveChanges();
        }

        public IQueryable<Submission> ReturnSubmissionForCurrentProblem(string problemId)
        {
            return this.database.Submissions
                .Where(x => x.ProblemId == problemId);

        }
    }
}
