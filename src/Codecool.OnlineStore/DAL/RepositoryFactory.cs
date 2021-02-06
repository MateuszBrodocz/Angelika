using Codecool.OnlineStore.DAL.Interfaces;
using Codecool.OnlineStore.DAL.Repositories;

namespace Codecool.OnlineStore.DAL
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly AllegrettoContext _context;

        public RepositoryFactory(AllegrettoContext context)
        {
            _context = context;
            Baskets = new BasketRepository(_context);
            Categories = new CategoryRepository(_context);
            Customers = new CustomerRepository(_context);
            Discounts = new DiscountRepository(_context);
            Orders = new OrderRepository(_context);
            Products = new ProductRepository(_context);
            Users = new UserRepository(_context);
            Countries = new CountryReposytory(_context);
        }

        public IBasketRepository Baskets { get; private set; }

        public ICategoryRepository Categories { get; private set; }

        public ICustomerRepository Customers { get; private set; }

        public IDiscountRepository Discounts { get; private set; }

        public IOrderRepository Orders { get; private set; }

        public IProductRepository Products { get; private set; }

        public IUserRepository Users { get; private set; }

        public ICountryRepository Countries { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
