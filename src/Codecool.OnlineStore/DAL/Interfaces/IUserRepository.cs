using Codecool.OnlineStore.Models;

namespace Codecool.OnlineStore.DAL.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User? GetUserIfAuthenticated(string username, string password);
    }
}
