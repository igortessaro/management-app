using System.Collections.Generic;

namespace Management.Domain.Entity
{
    public class Gender : BaseEntity
    {
        public string Name { get; set; }

        public IList<Customer> CustomerList { get; set; }
    }
}
