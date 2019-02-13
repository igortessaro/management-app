using Management.Domain.Dtos.Customer;
using System.Collections.Generic;

namespace Management.Domain.Services
{
    public interface ICustomerService : IService
    {
        IList<CustomerDto> Find(CustomerFilterDto customerFilter);
    }
}
