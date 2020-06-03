using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AddMinion
{
    public static class CommandCenter
    {
        public static int? GetVillainByName(string[] villainInfo, SqlConnection connection)
        {
            string checkIfVillainExistsQuery = @"SELECT Id FROM Villains WHERE Name = @Name";
            using (SqlCommand command = new SqlCommand(checkIfVillainExistsQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", villainInfo[1]);
                return (int?)command.ExecuteScalar();
            }
        }

        public static string GetVillainById(int id, SqlConnection connection)
        {
            string checkIfIdExists = @"SELECT Name FROM Villains WHERE Id = @villainId";
            using (SqlCommand command = new SqlCommand(checkIfIdExists, connection))
            {
                command.Parameters.AddWithValue("@villainId", id);
                return (string) command.ExecuteScalar();
            }
        }

        public static void MinionAdd(SqlConnection connection, string[] minionInfo, int? townId)
        {
            string insertMinionQuery = @"INSERT INTO Minions (Name, Age, TownId) VALUES (@nam, @age, @townId)";
            using (SqlCommand command = new SqlCommand(insertMinionQuery, connection))
            {
                command.Parameters.AddWithValue("@nam", minionInfo[1]);
                command.Parameters.AddWithValue("@age", minionInfo[2]);
                command.Parameters.AddWithValue("@townId", townId);
                command.ExecuteNonQuery();
            }
        }

        public static int? GetTownByName(string[] minionInfo, SqlConnection connection)
        {
            string checkIfTownExistsQuery = @"SELECT Id FROM Towns WHERE Name = @townName";
            using (SqlCommand command = new SqlCommand(checkIfTownExistsQuery, connection))
            {
                command.Parameters.AddWithValue("@townName", minionInfo[3]);
                return (int?)command.ExecuteScalar();
            }
        }

        public static void AddTown(SqlConnection connection, string townName)
        {
            string addTown = @"INSERT INTO Towns (Name) VALUES (@townName)";
            using (SqlCommand command = new SqlCommand(addTown, connection))
            {
                command.Parameters.AddWithValue("@townName", townName);
                command.ExecuteNonQuery();         
            }
            Console.WriteLine($"Town {townName} was added to the database.");
        }

        public static void AddVillain(SqlConnection connection, string villainName)
        {
            string villainAdd = @"INSERT INTO Villains (Name, EvilnessFactorId)  VALUES (@villainName, 4)";
            using (SqlCommand command = new SqlCommand(villainAdd, connection))
            {
                command.Parameters.AddWithValue("@villainName", villainName);
                command.ExecuteNonQuery();             
            }
            Console.WriteLine($"Villain {villainName} was added to the database.");
        }
         
        public static int? GetMinionId(SqlConnection connection, string minionName)
        {
            string getMinionQuery = @"SELECT Id FROM Minions WHERE Name = @Name";
            using (SqlCommand command = new SqlCommand(getMinionQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", minionName);
                return (int?) command.ExecuteScalar();
            }
        }

        public static void InsertInMappingTable(SqlConnection connection, int? minionId, int? villainId, string minionName, string villainName)
        {
            string insertInMapTableQuery = @"INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (@minionId, @villainId)";
            using (SqlCommand command = new SqlCommand(insertInMapTableQuery, connection))
            {
                command.Parameters.AddWithValue("@minionId", minionId);
                command.Parameters.AddWithValue("@villainId", villainId);
                command.ExecuteNonQuery();
            }
            Console.WriteLine($"Successfully added {minionName} to be minion of {villainName}.");
        }

        public static int UppercaseTowns(SqlConnection connection, string countryName)
        {
            string upperTownsQuery = @"UPDATE Towns
                                       SET Name = UPPER(Name)
                                       WHERE CountryCode = (SELECT c.Id FROM Countries AS c WHERE c.Name = @countryName)";
            using (SqlCommand command = new SqlCommand(upperTownsQuery, connection))
            {
                command.Parameters.AddWithValue("@countryName", countryName);
                return command.ExecuteNonQuery();
            }
        }

        public static void PrintTowns(SqlConnection connection, string countryName, int rowsAffected)
        {
            string printTowns = @"SELECT t.Name 
                                  FROM Towns as t
                                  JOIN Countries AS c ON c.Id = t.CountryCode
                                  WHERE c.Name = @countryName";
            using (SqlCommand command = new SqlCommand(printTowns, connection))
            {
                command.Parameters.AddWithValue("@countryName", countryName);
                IList<string> townsAffected = new List<string>();
                StringBuilder builder = new StringBuilder();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        townsAffected.Add((string)reader[0]);
                    }
                }

                builder.AppendLine($"{rowsAffected} town names were affected.")
                    .AppendLine($"[{String.Join(", ", townsAffected)}]");
                Console.WriteLine(builder.ToString().TrimEnd());
            }
        }

        public static void RemoveVillain(string query, string name, int id, SqlConnection connection)
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@villainId", id);
                command.ExecuteNonQuery();
            }
            Console.WriteLine($"{name} was deleted.");
        }

        public static int ReleaseMinions(string query, int id, SqlConnection connection)
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@villainId", id);
                return command.ExecuteNonQuery();
            }
        }
    }
}
