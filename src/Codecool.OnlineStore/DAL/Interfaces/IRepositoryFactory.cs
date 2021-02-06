using System;

namespace Codecool.OnlineStore.DAL.Interfaces
{
    public interface IRepositoryFactory
    {
        IBasketRepository Baskets { get; }

        ICategoryRepository Categories { get; }

        ICustomerRepository Customers { get; }

        IDiscountRepository Discounts { get; }

        IOrderRepository Orders { get; }

        IProductRepository Products { get; }

        IUserRepository Users { get; }

        ICountryRepository Countries { get; }

        int Complete();
    }
}
