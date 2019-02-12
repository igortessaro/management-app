using Management.Domain.Dtos;
using Management.Domain.Factories;

namespace Management.Infrastructure.Factories
{
    public class NotificationFactory : INotificationFactory
    {
        public NotificationDto<T> Success<T>(T payload)
        {
            var notification = new NotificationDto<T>();

            notification.Success = true;
            notification.Payload = payload;

            return notification;
        }

        public NotificationDto<string> Error(string message)
        {
            var notification = new NotificationDto<string>();

            notification.Erros.Add(message);
            notification.Success = false;
            notification.Payload = "NOK";

            return notification;
        }
    }
}
