using Management.Domain.Dtos;
using System.Collections.Generic;

namespace Management.Domain.Services
{
    public interface ICityService : IService
    {
        IList<ListItemDto> GetAll();
    }
}
