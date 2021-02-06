using System;
using System.Collections.Generic;
using Codecool.OnlineStore.DAL.Interfaces;
using Codecool.OnlineStore.Models;

namespace Codecool.OnlineStore.DAL.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(AllegrettoContext context)
            : base(context)
        {
        }

        public IEnumerable<Order> GetOrderByCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetOrderListByCustomer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
