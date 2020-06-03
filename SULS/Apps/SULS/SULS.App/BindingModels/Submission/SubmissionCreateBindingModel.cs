using SIS.MvcFramework.Attributes.Validation;

namespace SULS.App.BindingModels.Submission
{
    public class SubmissionCreateBindingModel
    {
        private const string ErrorMessageCode = "Invalid Submission! Should be between 30 and 800 characters.";

        public SubmissionCreateBindingModel() { }

        [RequiredSis]
        [StringLengthSis(30, 800, ErrorMessageCode)]
        public string Code { get; set; }
    }
}
