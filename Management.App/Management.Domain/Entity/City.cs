using System.Collections.Generic;

namespace Management.Domain.Entity
{
    public class City : BaseEntity
    {
        public string Name { get; set; }

        public int RegionId { get; set; }

        public Region Region { get; set; }

        public IList<Customer> CustomerList { get; set; }
    }
}
