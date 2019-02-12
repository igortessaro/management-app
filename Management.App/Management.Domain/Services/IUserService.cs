using Management.Domain.Dtos.User;

namespace Management.Domain.Services
{
    public interface IUserService : IService
    {
        UserSystemDto Find(string email, string password);
    }
}
