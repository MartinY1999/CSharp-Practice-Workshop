using SULS.App.ViewModels.Problem;
using System.Collections;
using System.Collections.Generic;

namespace SULS.App.ViewModels.Users
{
    public class UserHomeViewModel
    {
        public UserHomeViewModel()
        {
            this.Problems = new List<ProblemHomeViewModel>();
        }

        public List<ProblemHomeViewModel> Problems { get; set; }
    }
}
