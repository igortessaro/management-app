using Management.Domain.Dtos;
using Management.Domain.Dtos.User;
using Management.Domain.Repositories;
using Management.Domain.Services;
using System.Collections.Generic;

namespace Management.Infrastructure.Services
{
    public class UserService : IUserService
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

        public IList<ListItemDto> GetAll()
        {
            return this.UserSysRepository.GetAll();
        }
    }
}
