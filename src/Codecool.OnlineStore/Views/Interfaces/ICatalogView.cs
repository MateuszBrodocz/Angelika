using Codecool.OnlineStore.DAL;
using Codecool.OnlineStore.DAL.Interfaces;

namespace Codecool.OnlineStore.Views.Interfaces
{
    public interface ICatalogView : IView
    {
       bool IsCategoryAvailable();

       string GetCategoryName();

       void IsWrongInput(bool correctInput);

       int GetCategoryId(IRepositoryFactory repositoryFactory);

       int GetProductId(IRepositoryFactory repositoryFactory);
    }
}
