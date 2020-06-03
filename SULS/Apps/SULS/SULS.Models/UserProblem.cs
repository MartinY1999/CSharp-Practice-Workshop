namespace SULS.Models
{
    public class UserProblem
    {
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public string ProblemId { get; set; }
        public virtual Problem Problem { get; set; }
    }
}
