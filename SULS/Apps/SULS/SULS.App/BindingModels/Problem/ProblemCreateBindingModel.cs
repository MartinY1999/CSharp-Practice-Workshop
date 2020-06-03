using SIS.MvcFramework.Attributes.Validation;

namespace SULS.App.BindingModels.Problem
{
    public class ProblemCreateBindingModel
    {
        private const string ErrorMessageName = "Invalid Name! Should be between 5 and 20 characters";
        private const string ErrorMessagePoints = "Points should be between 50 and 300!";

        [RequiredSis]
        [StringLengthSis(5, 20, ErrorMessageName)]
        public string Name { get; set; }

        [RequiredSis]
        [RangeSis(50, 300, ErrorMessagePoints)]
        public int Points { get; set; }
    }
}
