using System;

namespace Management.Domain.Dtos.Customer
{
    public class CustomerFilterDto : IDto
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public int? Gender { get; set; }

        public int? City { get; set; }

        public int? Region { get; set; }

        public DateTime? LastPurchaseInitial { get; set; }

        public DateTime? LastPurchaseFinish { get; set; }

        public int? Classification { get; set; }

        public int? Seller { get; set; }
    }
}
