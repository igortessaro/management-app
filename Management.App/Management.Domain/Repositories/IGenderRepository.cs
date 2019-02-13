using Management.Domain.Dtos;
using System.Collections.Generic;

namespace Management.Domain.Repositories
{
    public interface IGenderRepository : IRepository
    {
        IList<ListItemDto> GetAll();
    }
}
