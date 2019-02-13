using Management.Domain.Dtos.Login;
using Management.Domain.Dtos.User;
using Management.Domain.Services;

namespace Management.Infrastructure.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public IUserService UserService { get; set; }

        public IEncryptionService EncryptionService { get; set; }

        public AuthenticationService(
            IUserService userService,
            IEncryptionService encryptionService)
        {
            this.UserService = userService;
            this.EncryptionService = encryptionService;
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

            string passwordDecrypt = this.EncryptionService.Decrypt(authenticateUser.Password);

            UserSystemDto userSystem = this.UserService.Find(authenticateUser.Email, passwordDecrypt);

            if (userSystem == null)
            {
                return new AuthenticatedUserDto("The email and/or password entered is invalid. Please try again.");
            }

            return new AuthenticatedUserDto(userSystem);
        }
    }
}
