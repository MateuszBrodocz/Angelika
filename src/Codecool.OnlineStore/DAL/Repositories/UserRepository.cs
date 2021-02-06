using System.Linq;
using Codecool.OnlineStore.DAL.Interfaces;
using Codecool.OnlineStore.Models;
using Microsoft.EntityFrameworkCore;

namespace Codecool.OnlineStore.DAL.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbContext context)
            : base(context)
        {
        }

        public User? GetUserIfAuthenticated(string username, string password)
        {
            return AllegrettoContext.Users
                .FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public AllegrettoContext AllegrettoContext
        {
            get { return Context as AllegrettoContext; }
        }
    }
}
