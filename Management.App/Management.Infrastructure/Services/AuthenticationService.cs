using Management.Domain.Dtos.Login;
using Management.Domain.Dtos.User;
using Management.Domain.Services;

namespace Management.Infrastructure.Services
{
    public class AuthenticationService
    {
        public IUserService UserService { get; set; }

        public AuthenticationService(
            IUserService userService)
        {
            this.UserService = userService;
        }

        public AuthenticatedUserDto AuthenticateUser(AuthenticateUserDto authenticateUser)
        {
            if (authenticateUser == null)
            {
                return new AuthenticatedUserDto($"{nameof(authenticateUser)} not found.");
            }

            if (string.IsNullOrEmpty(authenticateUser.Email))
            {
                return new AuthenticatedUserDto("Email is required.");
            }

            if (string.IsNullOrEmpty(authenticateUser.Password))
            {
                return new AuthenticatedUserDto("Password is required.");
            }

            UserSystemDto userSystem = this.UserService.Find(authenticateUser.Email, authenticateUser.Password);

            if (userSystem == null)
            {
                return new AuthenticatedUserDto("The email and/or password entered is invalid. Please try again.");
            }

            return new AuthenticatedUserDto(userSystem);
        }
    }
}
