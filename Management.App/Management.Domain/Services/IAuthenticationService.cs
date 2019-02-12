using Management.Domain.Dtos.Login;

namespace Management.Domain.Services
{
    public interface IAuthenticationService : IService
    {
        AuthenticatedUserDto AuthenticateUser(AuthenticateUserDto authenticateUser);
    }
}
