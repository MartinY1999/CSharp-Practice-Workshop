using System.Collections.Generic;

namespace SULS.Models
{
    public class User
    {
        public User()
        {
            this.Problems = new HashSet<UserProblem>();
        }

        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<UserProblem> Problems { get; set; }
    }
}