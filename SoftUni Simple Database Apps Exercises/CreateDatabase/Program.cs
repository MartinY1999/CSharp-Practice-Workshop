using System;
using System.Data.SqlClient;

namespace CreateDatabase
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();
                string cmd = "CREATE DATABASE MinionsDB";
                using (SqlCommand command = new SqlCommand(cmd, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
