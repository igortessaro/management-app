namespace Management.Domain.Services
{
    public interface IEncryptionService : IService
    {
        string Encrypt(string value);

        string Decrypt(string value);
    }
}
