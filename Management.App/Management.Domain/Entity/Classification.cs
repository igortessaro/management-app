using System.Collections.Generic;

namespace Management.Domain.Entity
{
    public class Classification: BaseEntity
    {
        public string Name { get; set; }

        public IList<Customer> CustomerList { get; set; }
    }
}
