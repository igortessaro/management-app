using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Management.Domain.Entity;

namespace Management.Infrastructure.Repositories.Relational.Mappers
{
    public class CityMap : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.Property(entity => entity.Id).HasColumnName("Id");

            builder.HasKey(entity => entity.Id);

            builder.ToTable(nameof(City), "dbo");

            builder.HasOne(p => p.Region).WithMany(b => b.CityList).HasForeignKey(p => p.RegionId);
        }
    }
}
