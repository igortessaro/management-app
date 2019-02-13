using Management.Domain.Dtos;
using System.Collections.Generic;

namespace Management.Domain.Repositories
{
    public interface IRegionRepository : IRepository
    {
        IList<ListItemDto> GetAll();
    }
}
