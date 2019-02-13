using Management.Domain.Dtos.Customer;
using Management.Domain.Entity;
using Management.Domain.Repositories;
using Management.Infrastructure.Repositories.Relational;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Management.Infrastructure.Repositories
{
    public class CustomerRepository : RelationalRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(PrincipalDbContext dbContext) : base(dbContext)
        {
        }

        public IList<CustomerDto> Find()
        {
            var result = this.Query()
                .Include(x => x.Gender)
                .Include(x => x.City)
                .Include(x => x.Region)
                .Include(x => x.Classification)
                .Include(x => x.User)
                .Select(x => new CustomerDto
                {
                    CityId = x.CityId,
                    City = x.City != null ? x.City.Name : string.Empty,
                    Classification = x.Classification != null ? x.Classification.Name : string.Empty,
                    ClassificationId = x.ClassificationId,
                    Gender = x.Gender != null ? x.Gender.Name : string.Empty,
                    GenderId = x.GenderId,
                    LastPurchase = x.LastPurchase,
                    Name = x.Name,
                    Phone = x.Phone,
                    Region = x.Region != null ? x.Region.Name : string.Empty,
                    RegionId = x.RegionId,
                    Seller = x.User != null ? x.User.Login : string.Empty,
                    SellerId = x.UserId
                })
                .ToList();

            return result;
        }
    }
}
