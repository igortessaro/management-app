namespace Management.Domain.Entity
{
    public class City : BaseEntity
    {
        public string Name { get; set; }

        public int RegionId { get; set; }
    }
}
