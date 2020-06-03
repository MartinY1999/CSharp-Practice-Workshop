﻿using System;
using System.Data.SqlClient;
using CreateDatabase;

namespace VillainsName
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();
                string query = @"SELECT v.Name, COUNT(mv.VillainId) AS MinionsCount  
                                 FROM Villains AS v 
                                 JOIN MinionsVillains AS mv ON v.Id = mv.VillainId 
                                 GROUP BY v.Id, v.Name 
                                 HAVING COUNT(mv.VillainId) > 3 
                                 ORDER BY COUNT(mv.VillainId)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = (string) reader["Name"];
                            int count = (int) reader["MinionsCount"];
                            Console.WriteLine($"{name} - {count}");
                        }
                    }
                }
            }
        }
    }
}
