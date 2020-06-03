using System;

namespace SULS.App.ViewModels.Submission
{
    public class SubmissionDetailsViewModel
    {
        public string Username { get; set; }
        public int AchievedResult { get; set; }
        public int MaxPoints { get; set; }
        public DateTime CreatedOn { get; set; }
        public string SubmissionId { get; set; }
    }
}
