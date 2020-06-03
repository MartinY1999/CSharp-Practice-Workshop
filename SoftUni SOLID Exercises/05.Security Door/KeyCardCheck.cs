namespace _05.Security_Door
{
    public class KeyCardCheck : SecurityCheck
    {
        private IRequestable securityUI;

        public KeyCardCheck(IRequestable securityUI)
        {
            this.securityUI = securityUI;
        }

        private bool IsValid(string code)
        {
            return true;
        }

        public override bool ValidateUser()
        {
            string code = securityUI.RequestKeyCard();
            if (IsValid(code))
            {
                return true;
            }

            return false;
        }
    }
}