using System.Collections.Generic;

namespace Management.Domain.Entity
{
    public class Region : BaseEntity
    {
        public string Name { get; set; }

        public IList<City> CityList { get; set; }

        public IList<Customer> CustomerList { get; set; }
    }
}
