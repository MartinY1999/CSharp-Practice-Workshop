using Microsoft.EntityFrameworkCore;
using SULS.Data;
using SULS.Models;
using SULS.Services.Contracts;
using System.Linq;

namespace SULS.Services
{
    public class UsersService : IUsersService
    {
        private readonly SULSContext database;

        public UsersService(SULSContext database)
        {
            this.database = database;
        }

        public void AddProblemToItsCreator(string problemId, string userId)
        {
            Problem problemToBeAdded = this.database.Problems.SingleOrDefault(p => p.Id == problemId);
            User currentUser = this.database.Users
                .Include(u => u.Problems)
                .ThenInclude(up => up.Problem)
                .SingleOrDefault(u => u.Id == u.Id);

            currentUser.Problems.Add(new UserProblem { Problem = problemToBeAdded });

            this.database.Update(currentUser);
            this.database.SaveChanges();
        }

        public void CreateUser(User user)
        {
            this.database.Users.Add(user);
            this.database.SaveChanges();
        }

        public User ReturnUserByData(string username, string password)
        {
            return database.Users.SingleOrDefault(user => (user.Username == username || user.Email == username)
                                                              && user.Password == password);
        }

        public User ReturnUserById(string id)
        {
            return database.Users
                .Include(u => u.Problems)
                .ThenInclude(up => up.Problem)
                .FirstOrDefault(user => user.Id == id);
        }
    }
}
