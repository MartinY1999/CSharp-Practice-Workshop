using System;
using System.Data.SqlClient;
using CreateDatabase;

namespace AddMinion
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] minionInfo = Console.ReadLine().Split();
            string[] villainInfo = Console.ReadLine().Split();
            using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();
                int? id = CommandCenter.GetTownByName(minionInfo, connection);
                if (id == null)
                {
                    CommandCenter.AddTown(connection, minionInfo[3]);
                    id = CommandCenter.GetTownByName(minionInfo, connection);
                }
                CommandCenter.MinionAdd(connection, minionInfo, id);
                int? villainId = CommandCenter.GetVillainByName(villainInfo, connection);
                if (villainId == null)
                {
                    CommandCenter.AddVillain(connection, villainInfo[1]);
                    villainId = CommandCenter.GetVillainByName(villainInfo, connection);
                }
                CommandCenter.InsertInMappingTable(connection, 
                    CommandCenter.GetMinionId(connection, minionInfo[1]), 
                    villainId, minionInfo[1], villainInfo[1]);
            }
        }
    }
}
