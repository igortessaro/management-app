using Management.Domain.Dtos.Customer;
using Management.Domain.Repositories;
using Management.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Management.Infrastructure.Services
{
    public class CustomerService : ICustomerService
    {
        public ICustomerRepository CustomerRepository { get; set; }

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.CustomerRepository = customerRepository;
        }

        public IList<CustomerDto> Find()
        {
            return this.CustomerRepository.Find();
        }
    }
}
