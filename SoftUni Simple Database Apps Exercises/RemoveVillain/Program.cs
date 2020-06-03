using System;
using System.Data.SqlClient;
using AddMinion;
using CreateDatabase;

namespace RemoveVillain
{
    class Program
    {
        static void Main(string[] args)
        {
            int idToDelete = int.Parse(Console.ReadLine());
            using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();
                string name = CommandCenter.GetVillainById(idToDelete, connection);
                if (String.IsNullOrEmpty(name))
                    Console.WriteLine("No such villain was found.");
                else
                {
                    string deleteFromMVCommand = @"DELETE FROM MinionsVillains 
                                                   WHERE VillainId = @villainId";
                    string deleteFromVCommand = @"DELETE FROM Villains
                                                  WHERE Id = @villainId";
                    int releasedMinions = CommandCenter.ReleaseMinions(deleteFromMVCommand, idToDelete, connection);
                    CommandCenter.RemoveVillain(deleteFromVCommand, name, idToDelete, connection);
                    Console.WriteLine($"{releasedMinions} minions were affected.");
                }
            }
        }
    }
}
