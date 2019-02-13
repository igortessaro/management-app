using Management.Domain.Dtos;
using System.Collections.Generic;

namespace Management.Domain.Services
{
    public interface IRegionService : IService
    {
        IList<ListItemDto> GetAll();
    }
}
