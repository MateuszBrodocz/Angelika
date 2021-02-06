using System;
using System.Linq;
using Codecool.OnlineStore.DAL.Interfaces;
using Codecool.OnlineStore.Models;
using Codecool.OnlineStore.Views.Interfaces;

namespace Codecool.OnlineStore.Controllers
{
    public class AccessController
    {
        private readonly IRepositoryFactory _db;
        private readonly IViewFactory _view;

        public AccessController(IRepositoryFactory db, IViewFactory view)
        {
            _db = db;
            _view = view;
        }

        public User Login()
        {
            _view.Access.ShowLoginPage();
            var username = _view.Access.GetUsername();
            var password = _view.Access.GetPassword();
            User? user;

            try
            {
                user = _db.Users.GetUserIfAuthenticated(username, password);
            }
            catch
            {
                throw new ArgumentException("There was a problem connecting to the database. Try again later.");
            }

            if (user == null)
            {
                throw new ArgumentException("Incorrect username or password.");
            }

            return user;
        }

        public User Register()
        {
            bool isUsernameFree = false;
            string username;

            _view.Access.ShowRegisterPage();
            do
            {
                username = _view.Access.GetUsername();

                try
                {
                    if (!_db.Users.Find(u => u.Username == username).Any())
                    {
                        isUsernameFree = true;
                    }
                    else
                    {
                        _view.Access.ShowMessage("User with given username already exists in this store.");
                    }
                }
                catch
                {
                    throw new ArgumentException("There was a problem connecting to the database. Try again later.");
                }
            }
            while (!isUsernameFree);

            string password = _view.Access.GetPassword();
            string firstname = _view.Access.GetFirstName();
            string lastname = _view.Access.GetLastName();
            string phonenumber = _view.Access.GetPhoneNumber();
            string streetname = _view.Access.GetStreetName();
            string postalcode = _view.Access.GetPostalCode();
            string city = _view.Access.GetCityName();
            Country country = _view.Access.GetCountyFromList(_db.Countries.GetAll());

            try
            {
                var user = _db.Users.Add(new User(username, password, UserRole.Customer));
                _db.Customers.Add(new Customer(user, firstname, lastname, phonenumber, streetname, postalcode, city, country));
                _db.Complete();
                return user;
            }
            catch
            {
                throw new ArgumentException("There was a problem connecting to the database. Try again later.");
            }
        }
    }
}
