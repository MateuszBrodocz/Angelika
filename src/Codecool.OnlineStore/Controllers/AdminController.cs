using System;
using System.Collections.Generic;
using Codecool.OnlineStore.DAL.Interfaces;
using Codecool.OnlineStore.Models;
using Codecool.OnlineStore.Views.ConsoleViews;
using Codecool.OnlineStore.Views.Interfaces;

namespace Codecool.OnlineStore.Controllers
{
    /// <summary>
    /// Admin Controller
    /// </summary>
    public class AdminController : GuestController
    {
        private readonly User _user;

        public AdminController(IRepositoryFactory db, IViewFactory view, User user)
            : base(db, view)
        {
            _user = user;
        }

        public void Start()
        {
            Console.WriteLine($"Hello {_user.Username}!");
            Console.WriteLine("Press something to logout...");
            Console.ReadLine();
        }

        private void AddProducts(IRepositoryFactory db)
        {
            UserInputSequenceView customerView = new UserInputSequenceView();
            string name = customerView.SingleWordSeter(1, 20);
            Product produktRepository = new Product(name);
            db.Products.Add(produktRepository);
            db.Complete();
        }

        private void EditProduct(IRepositoryFactory db, Product product)
        {
            UserInputSequenceView userInputSequenceView = new UserInputSequenceView();
            product.Name = userInputSequenceView.MultipleWordSeter(1, 30);
            product.Price = Convert.ToDecimal(userInputSequenceView.InputUser());
            product.Quantity = userInputSequenceView.NumberSeter(1, 1000);
            db.Products.Add(product);
            db.Complete();
        }

        private void SwitchProductAvaliability(IRepositoryFactory repositoryFactory)
        {
            int id = UnitOfView.Catalog.GetProductId(repositoryFactory);
            var product = repositoryFactory.Products.Get(id);
            if (product.IsAvailable == true)
            {
                product.IsAvailable = false;
            }
            else
            {
                product.IsAvailable = true;
            }

            repositoryFactory.Complete();
        }

        private void AddDiscount()
        {
            throw new NotImplementedException();
        }

        private void AddCategory(IRepositoryFactory repositoryFactory)
        {
            Category newCategory = new Category();
            newCategory.Name = UnitOfView.Catalog.GetCategoryName();
            newCategory.IsAvailable = UnitOfView.Catalog.IsCategoryAvailable();
            newCategory.Products = new List<Product>();
            repositoryFactory.Categories.Add(newCategory);
            repositoryFactory.Complete();
        }

        private void EditCategory(IRepositoryFactory repositoryFactory)
        {
            int id = UnitOfView.Catalog.GetCategoryId(repositoryFactory);
            var category = repositoryFactory.Categories.Get(id);
            category.Name = UnitOfView.Catalog.GetCategoryName();
            repositoryFactory.Complete();
        }

        private void RemoveCategory(IRepositoryFactory repositoryFactory)
        {
            int id = UnitOfView.Catalog.GetCategoryId(repositoryFactory);
            var category = repositoryFactory.Categories.Get(id);
            repositoryFactory.Categories.Remove(category);
            repositoryFactory.Complete();
        }

        private void VoidShowStatistics()
        {
            throw new NotImplementedException();
        }

        private void ShowCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
