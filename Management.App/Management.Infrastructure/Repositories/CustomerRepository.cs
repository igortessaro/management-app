using Management.Domain.Dtos.Customer;
using Management.Domain.Entity;
using Management.Domain.Repositories;
using Management.Infrastructure.Repositories.Relational;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Management.Infrastructure.Repositories
{
    public class CustomerRepository : RelationalRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(PrincipalDbContext dbContext) : base(dbContext)
        {
        }

        public IList<CustomerDto> Find(int? userId, CustomerFilterDto customerFilter)
        {
            IQueryable<Customer> query = this.Query()
                .Include(x => x.Gender)
                .Include(x => x.City)
                .Include(x => x.Region)
                .Include(x => x.Classification)
                .Include(x => x.User);

            if (userId.HasValue)
            {
                query = query.Where(x => x.UserId == userId);
            }

            if (customerFilter.City.HasValue)
            {
                query = query.Where(x => x.CityId == customerFilter.City);
            }

            if (customerFilter.Classification.HasValue)
            {
                query = query.Where(x => x.ClassificationId == customerFilter.Classification);
            }

            if (customerFilter.Gender.HasValue)
            {
                query = query.Where(x => x.GenderId == customerFilter.Gender);
            }

            if (!string.IsNullOrEmpty(customerFilter.Name))
            {
                query = query.Where(x => customerFilter.Name.Contains(x.Name));
            }

            if (customerFilter.Seller.HasValue)
            {
                query = query.Where(x => x.UserId == customerFilter.Seller);
            }

            var result = query
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
