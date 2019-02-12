using System;

namespace Management.Domain.Entity
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public int GenderId { get; set; }

        public int? CityId { get; set; }

        public int? RegionId { get; set; }

        public DateTime? LastPurchase { get; set; }

        public int? ClassificationId { get; set; }

        public int? UserId { get; set; }
    }
}
