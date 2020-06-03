using SULS.App.ViewModels.Submission;
using System.Collections.Generic;

namespace SULS.App.ViewModels.Problem
{
    public class ProblemDetailsViewModel
    {
        public ProblemDetailsViewModel()
        {
            this.Submissions = new List<SubmissionDetailsViewModel>();
        }

        public string Name { get; set; }
        public List<SubmissionDetailsViewModel> Submissions { get; set; }
    }
}
