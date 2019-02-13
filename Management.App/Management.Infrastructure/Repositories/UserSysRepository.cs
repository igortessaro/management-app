using Management.Domain.Dtos.User;
using Management.Domain.Entity;
using Management.Domain.Repositories;
using Management.Domain.ValueObjects;
using Management.Infrastructure.Repositories.Relational;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Management.Infrastructure.Repositories
{
    public class UserSysRepository : RelationalRepository<UserSys>, IUserSysRepository
    {
        public UserSysRepository(PrincipalDbContext dbContext)
            : base(dbContext)
        {
        }

        public UserSystemDto Find(string email, string password)
        {
            return this.Query()
                .Include(x => x.UserRole)
                .Where(x => x.Email.Equals(email) && x.Password.Equals(password))
                .Select(x => new UserSystemDto
                {
                    Email = x.Email,
                    Name = x.Login,
                    UserType = x.UserRole != null && x.UserRole.IsAdmin ? UserType.Adm : UserType.Saller
                }).FirstOrDefault();
        }
    }
}
