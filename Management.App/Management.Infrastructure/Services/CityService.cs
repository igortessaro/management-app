using Management.Domain.Entity;
using Management.Domain.Repositories;
using Management.Domain.Services;
using System.Collections.Generic;

namespace Management.Infrastructure.Services
{
    public class CityService : ICityService
    {
        private ICityRespository CityRepository { get; set; }

        public CityService(ICityRespository cityRepository)
        {
            this.CityRepository = cityRepository;
        }

        public IList<City> GetAll()
        {
            return this.CityRepository.GetAll();
        }
    }
}
