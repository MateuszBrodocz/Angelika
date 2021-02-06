using System.Collections.Generic;
using Codecool.OnlineStore.Models;

namespace Codecool.OnlineStore.Views.Interfaces
{
    public interface IAccessView : IView
    {
        string GetUsername();

        string GetPassword();

        void ShowLoginPage();

        void ShowRegisterPage();

        string GetFirstName();

        string GetLastName();

        string GetPhoneNumber();

        string GetStreetName();

        string GetPostalCode();

        string GetCityName();

        Country GetCountyFromList(IEnumerable<Country> enumerable);
    }
}
