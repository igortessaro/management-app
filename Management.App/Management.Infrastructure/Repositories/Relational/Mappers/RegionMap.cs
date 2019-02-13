using Management.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Management.Infrastructure.Repositories.Relational.Mappers
{
    public class RegionMap : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.Property(entity => entity.Id).HasColumnName("Id");

            builder.HasKey(entity => entity.Id);

            builder.ToTable(nameof(Region), "dbo");

            builder.HasMany(p => p.CityList).WithOne(b => b.Region).HasForeignKey(p => p.RegionId);

            builder.HasMany(p => p.CustomerList).WithOne(b => b.Region).HasForeignKey(p => p.RegionId);
        }
    }
}
