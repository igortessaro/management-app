using Management.Domain.Dtos;
using Management.Domain.Entity;
using Management.Domain.Repositories;
using Management.Infrastructure.Repositories.Relational;
using System.Collections.Generic;
using System.Linq;

namespace Management.Infrastructure.Repositories
{
    public class GenderRepository : RelationalRepository<Gender>, IGenderRepository
    {
        public GenderRepository(PrincipalDbContext dbContext) : base(dbContext)
        {
        }

        public IList<ListItemDto> GetAll()
        {
            return this.Query()
                .Select(x => new ListItemDto
                {
                    Key = x.Id,
                    Value = x.Name
                })
                .ToList();
        }
    }
}
