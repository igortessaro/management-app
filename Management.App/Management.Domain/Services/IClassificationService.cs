using Management.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Management.Domain.Services
{
    public interface IClassificationService : IService
    {
        IList<ListItemDto> GetAll();
    }
}
