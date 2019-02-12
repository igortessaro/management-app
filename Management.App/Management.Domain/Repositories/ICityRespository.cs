using Management.Domain.Entity;
using System.Collections.Generic;

namespace Management.Domain.Repositories
{
    public interface ICityRespository : IRepository
    {
        IList<City> GetAll();
    }
}
