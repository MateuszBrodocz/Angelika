using Codecool.OnlineStore.DAL.Interfaces;
using Codecool.OnlineStore.Models;

namespace Codecool.OnlineStore.DAL.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(AllegrettoContext context)
            : base(context)
        {
        }
    }
}
