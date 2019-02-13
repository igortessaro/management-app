using Management.Domain.Dtos;
using Management.Domain.Repositories;
using Management.Domain.Services;
using System.Collections.Generic;

namespace Management.Infrastructure.Services
{
    public class GenderService : IGenderService
    {
        public IGenderRepository GenderRepository { get; set; }

        public GenderService(IGenderRepository genderRepository)
        {
            this.GenderRepository = genderRepository;
        }

        public IList<ListItemDto> GetAll()
        {
            return this.GenderRepository.GetAll();
        }
    }
}
