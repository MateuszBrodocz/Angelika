using Codecool.OnlineStore.DAL.Interfaces;
using Codecool.OnlineStore.Models;

namespace Codecool.OnlineStore.DAL.Repositories
{
    public class CountryReposytory : Repository<Country>, ICountryRepository
    {
        public CountryReposytory(AllegrettoContext context)
            : base(context)
        {
        }
    }
}
