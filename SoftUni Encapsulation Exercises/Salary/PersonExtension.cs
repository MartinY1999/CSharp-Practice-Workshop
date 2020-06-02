namespace PersonsInfo
{
    public static class PersonExtension
    {
        public static decimal IncreaseSalary(this Person currentPerson, decimal percentage)
        {
            if (currentPerson.Age > 30)
                return currentPerson.Salary += currentPerson.Salary * percentage / 100;
            else
                return currentPerson.Salary += currentPerson.Salary * percentage / 200;
        }
    }
}
