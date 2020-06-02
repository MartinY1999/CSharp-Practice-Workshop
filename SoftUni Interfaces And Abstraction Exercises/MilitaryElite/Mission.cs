using System;

namespace MilitaryElite
{
    public class Mission
    {
        private string codeName;
        private string state;
        public string CodeName
        {
            get => codeName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("");
                codeName = value;
            }
        }
        public string State
        {
            get => state;
            private set
            {
                if (value == "inProgress" || value == "Finished")
                    state = value;
                else
                    throw new ArgumentException("");
            }
        }
        public Mission(string codeName, string state)
        {
            CodeName = codeName;
            State = state;
        }
        public static Mission Create(string name, string state)
        {
            return new Mission(name, state);
        }
        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
