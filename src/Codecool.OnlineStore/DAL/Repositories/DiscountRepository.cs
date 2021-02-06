using Codecool.OnlineStore.DAL.Interfaces;
using Codecool.OnlineStore.Models;

namespace Codecool.OnlineStore.DAL.Repositories
{
    public class DiscountRepository : Repository<Discount>, IDiscountRepository
    {
        public DiscountRepository(AllegrettoContext context)
            : base(context)
        {
        }
    }
}
