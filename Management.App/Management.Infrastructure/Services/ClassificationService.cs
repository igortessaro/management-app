using Management.Domain.Dtos;
using Management.Domain.Repositories;
using Management.Domain.Services;
using System.Collections.Generic;

namespace Management.Infrastructure.Services
{
    public class ClassificationService : IClassificationService
    {
        private IClassificationRepository ClassificationRepository { get; set; }

        public ClassificationService(IClassificationRepository classificationRepository)
        {
            this.ClassificationRepository = classificationRepository;
        }

        public IList<ListItemDto> GetAll()
        {
            return this.ClassificationRepository.GetAll();
        }
    }
}