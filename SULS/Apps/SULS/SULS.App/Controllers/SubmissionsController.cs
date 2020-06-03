using SIS.MvcFramework;
using SIS.MvcFramework.Attributes;
using SIS.MvcFramework.Attributes.Security;
using SIS.MvcFramework.Result;
using SULS.App.BindingModels.Submission;
using SULS.App.ViewModels.Problem;
using SULS.Models;
using SULS.Services.Contracts;

namespace SULS.App.Controllers
{
    public class SubmissionsController : Controller
    {
        private readonly ISubmissionsService submissionsService;
        private readonly IProblemsService problemsService;

        public SubmissionsController(ISubmissionsService submissionsService, IProblemsService problemsService)
        {
            this.submissionsService = submissionsService;
            this.problemsService = problemsService;
        }

        [Authorize]
        public IActionResult Create(string id)
        {
            Problem currentProblem = this.problemsService.ReturnCurrentProblem(id);
            ProblemSubmissionViewModel problemSubmissionViewModel = new ProblemSubmissionViewModel()
            {
                ProblemId = currentProblem.Id,
                Name = currentProblem.Name
            };

            return this.View(problemSubmissionViewModel);
        }

        [HttpPost]
        public IActionResult Create(string problemId, SubmissionCreateBindingModel model)
        {
            if (!this.ModelState.IsValid)
               return this.Redirect("/Submissions/Create");

            this.submissionsService.CreateSubmission(problemId, this.User.Id, model.Code);

            return this.Redirect("/");
        }

        [Authorize]
        public IActionResult Delete(string submissionId)
        {
            this.submissionsService.Delete(submissionId);
            return this.Redirect("/");
        }
    }
}
