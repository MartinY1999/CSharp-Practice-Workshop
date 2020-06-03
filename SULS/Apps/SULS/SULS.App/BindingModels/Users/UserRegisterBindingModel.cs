using SIS.MvcFramework.Attributes.Validation;

namespace SULS.App.BindingModels.Users
{
    public class UserRegisterBindingModel
    {
        private const string ErrorMessageUsername = "Invalid Username! Should be between 5 and 20 characters.";
        private const string ErrorMessageEmail = "Invalid Email!";
        private const string ErrorMessagePassword = "Invalid Password! Should be between 6 and 20 characters.";

        [RequiredSis]
        [StringLengthSis(5, 20, ErrorMessageUsername)]
        public string Username { get; set; }

        [RequiredSis]
        [EmailSis(ErrorMessageEmail)]
        public string Email { get; set; }

        [RequiredSis]
        [StringLengthSis(6, 20, ErrorMessagePassword)]
        [PasswordSis(ErrorMessageUsername)]
        public string Password { get; set; }

        [RequiredSis]
        public string ConfirmPassword { get; set; }
    }
}
