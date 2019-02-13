using Management.Domain.Dtos;
using System.Collections.Generic;

namespace Management.Domain.Services
{
    public interface IGenderService : IService
    {
        IList<ListItemDto> GetAll();
    }
}
