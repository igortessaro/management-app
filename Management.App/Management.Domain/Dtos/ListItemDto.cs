namespace Management.Domain.Dtos
{
    public class ListItemDto : IDto
    {
        public int Key { get; set; }

        public int? ForeignKey { get; set; }

        public string Value { get; set; }
    }
}
