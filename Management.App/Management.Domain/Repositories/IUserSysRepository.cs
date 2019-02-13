using Management.Domain.Dtos;
using Management.Domain.Dtos.User;
using System.Collections.Generic;

namespace Management.Domain.Repositories
{
    public interface IUserSysRepository : IRepository
    {
        UserSystemDto Find(string email, string password);

        IList<ListItemDto> GetAll();

        bool UserAdmin(int userId);
    }
}
