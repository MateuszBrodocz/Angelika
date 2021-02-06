using Codecool.OnlineStore.Models;
using Codecool.OnlineStore.DAL.Interfaces;

namespace Codecool.OnlineStore.DAL.Repositories
{
    public class BasketRepository : Repository<BasketItem>, IBasketRepository
    {
        public BasketRepository(AllegrettoContext context)
            : base(context)
        {
        }

        public System.Collections.Generic.IEnumerable<BasketItem> GetBasketByCustomer(int id)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<BasketItem> GetBasketListByCustomer(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
