using Management.Domain.Dtos;
using System.Collections.Generic;

namespace Management.Domain.Repositories
{
    public interface ICityRespository : IRepository
    {
        IList<ListItemDto> GetAll();
    }
}
