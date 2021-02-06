using System.Collections.Generic;
using Codecool.OnlineStore.Models;

namespace Codecool.OnlineStore.DAL.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        IEnumerable<Order> GetOrderByCustomer(int id);

        IEnumerable<Order> GetOrderListByCustomer(int id);
    }
}
