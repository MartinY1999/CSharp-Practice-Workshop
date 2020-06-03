using SIS.MvcFramework;
using SIS.MvcFramework.Attributes;
using SIS.MvcFramework.Attributes.Security;
using SIS.MvcFramework.Mapping;
using SIS.MvcFramework.Result;
using SULS.App.ViewModels.Problem;
using SULS.App.ViewModels.Users;
using SULS.Models;
using SULS.Services.Contracts;

namespace SULS.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsersService usersService;
        private readonly ISubmissionsService submissionsService;

        public HomeController(IUsersService usersService, ISubmissionsService submissionsService)
        {
            this.usersService = usersService;
            this.submissionsService = submissionsService;
        }

        [HttpGet(Url = "/")]
        public IActionResult IndexSlash()
        {
            if (this.IsLoggedIn())
                return this.IndexLoggedIn();

            return this.Index();
        }

        public IActionResult Index()
        {
            return this.View();
        }

        [Authorize]
        public IActionResult IndexLoggedIn()
        {
            User user = this.usersService.ReturnUserById(this.User.Id);

            UserHomeViewModel userHomeViewModel = user.To<UserHomeViewModel>();
            userHomeViewModel.Problems.Clear();

            foreach (UserProblem userProblem in user.Problems)
            {
                ProblemHomeViewModel problemHomeViewModel = new ProblemHomeViewModel()
                {
                    Id = userProblem.ProblemId,
                    Name = userProblem.Problem.Name,
                    Count = this.submissionsService.CountOfSubmissionsForCurrentProblem(userProblem.ProblemId)
                };
                userHomeViewModel.Problems.Add(problemHomeViewModel);
            }

            return this.View(userHomeViewModel);
        }


    }
}