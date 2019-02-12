using Management.Domain.Dtos.User;
using Management.Domain.ValueObjects;

namespace Management.Domain.Dtos.Login
{
    public class AuthenticatedUserDto : IDto
    {
        public AuthenticatedUserDto()
        {
        }

        public AuthenticatedUserDto(string error)
            : this()
        {
            this.Authenticated = false;
            this.Error = error;
        }

        public AuthenticatedUserDto(UserSystemDto userSystem)
            : this()
        {
            this.Authenticated = true;
            this.UserSystem = userSystem;
        }

        public bool Authenticated { get; set; }

        public string Error { get; set; }

        public UserSystemDto UserSystem { get; set; }
    }
}
