using System.Collections.Generic;
using Codecool.OnlineStore.Models;

namespace Codecool.OnlineStore.DAL.Interfaces
{
    public interface IBasketRepository : IRepository<BasketItem>
    {
        IEnumerable<BasketItem> GetBasketByCustomer(int id);

        IEnumerable<BasketItem> GetBasketListByCustomer(int id);
    }
}
