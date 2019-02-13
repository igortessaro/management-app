using Management.Domain.Dtos;
using System.Collections.Generic;

namespace Management.Domain.Repositories
{
    public interface IClassificationRepository : IRepository
    {
        IList<ListItemDto> GetAll();
    }
}
