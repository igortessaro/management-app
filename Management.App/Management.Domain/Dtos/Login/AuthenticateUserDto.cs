namespace Management.Domain.Dtos.Login
{
    public class AuthenticateUserDto : IDto
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
