using Management.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Management.Domain.Services
{
    public interface ICityService : IService
    {
        IList<City> GetAll();
    }
}
