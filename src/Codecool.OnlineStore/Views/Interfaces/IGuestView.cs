using System.Collections.Generic;
using Codecool.OnlineStore.Models;

namespace Codecool.OnlineStore.Views.Interfaces
{
    public interface IGuestView : IView
    {
        string GetText(string inputRequestMessage);

        bool IsStringValid(string searchFrase, string validStringPattern);
    }
}
