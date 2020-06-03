using SULS.Models;

namespace SULS.Services.Contracts
{
    public interface IUsersService
    {
        void CreateUser(User user);
        User ReturnUserByData(string username, string password);
        User ReturnUserById(string id);
        void AddProblemToItsCreator(string problemId, string userId);
    }
}
