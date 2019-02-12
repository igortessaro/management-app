using System.Collections.Generic;

namespace Management.Domain.Dtos
{
    public class NotificationDto<T>
    {
        public NotificationDto()
        {
            this.Erros = new List<string>();
            this.Warnings = new List<string>();
            this.Validations = new List<string>();
        }

        public bool Success { get; set; }

        public T Payload { get; set; }

        public IList<string> Erros { get; set; }

        public IList<string> Warnings { get; set; }

        public IList<string> Validations { get; set; }
    }
}
