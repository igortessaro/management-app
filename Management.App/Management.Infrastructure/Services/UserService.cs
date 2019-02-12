using Management.Domain.Dtos.User;
using Management.Domain.Repositories;

namespace Management.Infrastructure.Services
{
    public class UserService
    {
        public IUserSysRepository UserSysRepository { get; set; }

        public UserService(
            IUserSysRepository userSysRepository)
        {
            this.UserSysRepository = userSysRepository;
        }

        public UserSystemDto Find(string email, string password)
        {
            return this.UserSysRepository.Find(email, password);
        }
    }
}
