using SIS.MvcFramework;
using SIS.MvcFramework.Attributes;
using SIS.MvcFramework.Attributes.Security;
using SIS.MvcFramework.Result;
using SIS.MvcFramework.Mapping;
using SULS.App.BindingModels.Problem;
using SULS.Models;
using SULS.Services.Contracts;
using SULS.App.ViewModels.Problem;
using System.Linq;
using System.Collections.Generic;
using SULS.App.ViewModels.Submission;

namespace SULS.App.Controllers
{
    public class ProblemsController : Controller
    {
        private readonly IProblemsService problemsService;
        private readonly IUsersService usersService;
        private readonly ISubmissionsService submissionsService;

        public ProblemsController(IProblemsService problemsService, IUsersService usersService, ISubmissionsService submissionsService)
        {
            this.problemsService = problemsService;
            this.usersService = usersService;
            this.submissionsService = submissionsService;
        }

        [Authorize]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(ProblemCreateBindingModel model)
        {
            if (!this.ModelState.IsValid)
                return this.View();

            Problem problem = this.problemsService.CreateProblem(model.To<Problem>());
            this.usersService.AddProblemToItsCreator(problem.Id, this.User.Id);

            return this.Redirect("/");
        }

        [Authorize]
        public IActionResult Details(string id)
        {
            Problem currentProblem = this.problemsService.ReturnCurrentProblem(id);
            IQueryable<Submission> submissionsForCurrentProblem = this.submissionsService.ReturnSubmissionForCurrentProblem(id);

            ProblemDetailsViewModel problemDetailsViewModel = new ProblemDetailsViewModel()
            {
                Name = currentProblem.Name,
                Submissions = new List<SubmissionDetailsViewModel>()
            };
            foreach (Submission submission in submissionsForCurrentProblem)
            {
                SubmissionDetailsViewModel sdvm = new SubmissionDetailsViewModel()
                {
                    Username = submission.User.Username,
                    AchievedResult = submission.AchievedResult,
                    MaxPoints = currentProblem.Points,
                    CreatedOn = submission.CreatedOn,
                    SubmissionId = submission.Id
                };
                problemDetailsViewModel.Submissions.Add(sdvm);
            }

            return this.View(problemDetailsViewModel);
        }
    }
}
