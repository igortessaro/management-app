using Management.Domain.Entity;
using Management.Domain.Repositories;
using Management.Infrastructure.Repositories.Relational;
using System.Collections.Generic;

namespace Management.Infrastructure.Repositories
{
    public class CityRepository : RelationalRepository<City>, ICityRespository
    {
        public CityRepository(PrincipalDbContext dbContext) : base(dbContext)
        {
        }

        public IList<City> GetAll()
        {
            return this.QueryAll();
        }
    }
}
