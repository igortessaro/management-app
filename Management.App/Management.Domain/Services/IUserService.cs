using Management.Domain.Dtos;
using Management.Domain.Dtos.User;
using System.Collections.Generic;

namespace Management.Domain.Services
{
    public interface IUserService : IService
    {
        UserSystemDto Find(string email, string password);

        IList<ListItemDto> GetAll();

        bool UserAdmin(int userId);
    }
}
