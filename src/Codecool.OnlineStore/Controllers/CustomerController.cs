using System;
using Codecool.OnlineStore.DAL.Interfaces;
using Codecool.OnlineStore.Models;
using Codecool.OnlineStore.Views.Interfaces;

namespace Codecool.OnlineStore.Controllers
{
    public class CustomerController : GuestController
    {
        private readonly User _user;

        public CustomerController(IRepositoryFactory db, IViewFactory view, User user)
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

        private void ShowPersonalData()
        {
            throw new NotImplementedException();
        }

        private void EditPersonalData()
        {
            throw new NotImplementedException();
        }

        private void EnlistOrders()
        {
            throw new NotImplementedException();
        }

        private void ShowBasket()
        {
            throw new NotImplementedException();
        }
    }
}