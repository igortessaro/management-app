using Management.Domain.Dtos;

namespace Management.Domain.Factories
{
    public interface INotificationFactory : IFactory
    {
        NotificationDto<T> Success<T>(T payload);

        NotificationDto<string> Error(string message);
    }
}
