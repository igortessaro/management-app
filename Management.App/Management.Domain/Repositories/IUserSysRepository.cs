using Management.Domain.Dtos.User;

namespace Management.Domain.Repositories
{
    public interface IUserSysRepository : IRepository
    {
        UserSystemDto Find(string email, string password);
    }
}
