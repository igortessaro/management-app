using Management.Domain.Dtos.Customer;
using System.Collections.Generic;

namespace Management.Domain.Repositories
{
    public interface ICustomerRepository : IRepository
    {
        IList<CustomerDto> Find(int? userId, CustomerFilterDto customerFilter);
    }
}
