using System;

namespace Management.Domain.Dtos.Customer
{
    public class CustomerDto : IDto
    {
        public int? ClassificationId { get; set; }

        public string Classification { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public int? GenderId { get; set; }

        public string Gender { get; set; }

        public int? CityId { get; set; }

        public string City { get; set; }

        public int? RegionId { get; set; }

        public string Region { get; set; }

        public DateTime? LastPurchase { get; set; }

        public int? SellerId { get; set; }

        public string Seller { get; set; }
    }
}
