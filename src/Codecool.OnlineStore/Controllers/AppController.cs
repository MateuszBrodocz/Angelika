using System;
using Codecool.OnlineStore.DAL.Interfaces;
using Codecool.OnlineStore.Models;
using Codecool.OnlineStore.Views.Interfaces;

namespace Codecool.OnlineStore.Controllers
{
    public class AppController
    {
        private readonly IRepositoryFactory _db;
        private readonly IViewFactory _view;

        public AppController(IRepositoryFactory db, IViewFactory view)
        {
            _db = db;
            _view = view;
        }

        public void Run()
        {
            string[] options = new string[]
            {
                "login",
                "register",
                "enlist all products",
                "enlist products by category",
                "search products",
                "exit",
            };

            bool isRun = true;
            while (isRun)
            {
                var selectedOption = _view.App.GetOption("Main menu", options);

                switch (selectedOption)
                {
                    case "login":
                        Login();
                        break;
                    case "register":
                        Register();
                        break;
                    case "enlist all products":
                        new GuestController(_db, _view).ChooseFromAllProducts();
                        break;
                    case "enlist products by category":
                        new GuestController(_db, _view).ChooseProductFromChosenCategory();
                        break;
                    case "search products":
                        new GuestController(_db, _view).ChooseProductBySearch();
                        break;
                    case "exit":
                        isRun = false;
                        break;
                    default:
                        break;
                }
            }
        }

        private void Register()
        {
            var accessController = new AccessController(_db, _view);
            bool isBack;
            User? user = null;
            do
            {
                try
                {
                    user = accessController.Register();
                }
                catch (ArgumentException e)
                {
                    _view.App.ShowMessage(e.Message);
                }

                if (user != null)
                {
                    new CustomerController(_db, _view, user).Start();
                    isBack = true;
                }
                else
                {
                    _view.App.ShowMessage("Do you want to back to the main page? y/n");
                    isBack = _view.App.GetYesOrNo();
                }
            }
            while (!isBack);
        }

        private void Login()
        {
            var accessController = new AccessController(_db, _view);
            bool isBack;
            User? user = null;
            do
            {
                try
                {
                    user = accessController.Login();
                }
                catch (ArgumentException e)
                {
                    _view.App.ShowMessage(e.Message);
                }

                if (user != null)
                {
                    if (user.Role == UserRole.Admin)
                    {
                        new AdminController(_db, _view, user).Start();
                    }
                    else if (user.Role == UserRole.Customer)
                    {
                        new CustomerController(_db, _view, user).Start();
                    }

                    isBack = true;
                }
                else
                {
                    _view.App.ShowMessage("Do you want to back to the main page? y/n");
                    isBack = _view.App.GetYesOrNo();
                }
            }
            while (!isBack);
        }
    }
}
