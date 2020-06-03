using System.Collections.Generic;

namespace ExtendedDatabase.Interfaces
{
    public interface IDatabase
    {
        void Add(IPerson person);
        void Remove(string person);
        IPerson FindByID(long id);
        IPerson FindByUsername(string username);
    }
}
