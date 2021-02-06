namespace Codecool.OnlineStore.Views.Interfaces
{
    public interface IViewFactory
    {
        public IAccessView Access { get; }

        public IAppView App { get; }

        public ICatalogView Catalog { get; }

        public IGuestView Guest { get; }
    }
}
