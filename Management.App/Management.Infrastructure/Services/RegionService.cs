using Management.Domain.Dtos;
using Management.Domain.Repositories;
using Management.Domain.Services;
using System.Collections.Generic;

namespace Management.Infrastructure.Services
{
    public class RegionService : IRegionService
    {
        public IRegionRepository RegionRepository { get; set; }

        public RegionService(IRegionRepository regionRepository)
        {
            this.RegionRepository = regionRepository;
        }

        public IList<ListItemDto> GetAll()
        {
            return this.RegionRepository.GetAll();
        }
    }
}
