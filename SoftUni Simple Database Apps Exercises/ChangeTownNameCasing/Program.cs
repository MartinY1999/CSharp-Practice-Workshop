using System;
using System.Data.SqlClient;
using AddMinion;
using CreateDatabase;

namespace ChangeTownNameCasing
{
    public class Program
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();
            using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();
                int rowsAffected = CommandCenter.UppercaseTowns(connection, countryName);
                if (rowsAffected == 0)
                {
                    Console.WriteLine("No town names were affected.");
                    return;
                }
                CommandCenter.PrintTowns(connection, countryName, rowsAffected);
            }
        }
    }
}
