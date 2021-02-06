using Codecool.OnlineStore.DAL.Interfaces;
using Codecool.OnlineStore.Models;

namespace Codecool.OnlineStore.DAL.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(AllegrettoContext context)
            : base(context)
        {
        }
    }
}
