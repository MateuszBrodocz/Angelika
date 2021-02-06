using Codecool.OnlineStore.DAL.Interfaces;
using Codecool.OnlineStore.Models;

namespace Codecool.OnlineStore.DAL.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AllegrettoContext context)
            : base(context)
        {
        }
    }
}
