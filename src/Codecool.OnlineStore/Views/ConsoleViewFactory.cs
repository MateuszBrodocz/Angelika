using Codecool.OnlineStore.Views.ConsoleViews;
using Codecool.OnlineStore.Views.Interfaces;

namespace Codecool.OnlineStore.Views
{
    public class ConsoleViewFactory : IViewFactory
    {
        public ConsoleViewFactory()
        {
            Access = new AccessConsoleView();
            App = new AppConsoleView();
            Catalog = new CatalogConsoleView();
            Guest = new GuestView();
        }

        public IAccessView Access { get; }

        public IGuestView Guest { get; }

        public IAppView App { get; }

        public ICatalogView Catalog { get; }
    }
}
