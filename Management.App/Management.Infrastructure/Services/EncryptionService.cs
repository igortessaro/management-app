using Management.Domain.Services;

namespace Management.Infrastructure.Services
{
    public class EncryptionService : IEncryptionService
    {
        public string Encrypt(string value)
        {
            return value;
        }

        public string Decrypt(string value)
        {
            return value;
        }
    }
}
