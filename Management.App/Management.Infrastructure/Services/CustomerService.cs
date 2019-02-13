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

        public IUserService UserService { get; set; }

        public CustomerService(ICustomerRepository customerRepository, IUserService userService)
        {
            this.CustomerRepository = customerRepository;
            this.UserService = userService;
        }

        public IList<CustomerDto> Find(CustomerFilterDto customerFilter)
        {
            if (this.UserAdmin(customerFilter.UserId))
            {
                return this.CustomerRepository.Find(null, customerFilter);
            }

            return this.CustomerRepository.Find(customerFilter.UserId, customerFilter);
        }

        private bool UserAdmin(int userId)
        {
            return this.UserService.UserAdmin(userId);
        }
    }
}
