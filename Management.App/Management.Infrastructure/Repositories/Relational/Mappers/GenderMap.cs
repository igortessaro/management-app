using Management.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Management.Infrastructure.Repositories.Relational.Mappers
{
    public class GenderMap : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.Property(entity => entity.Id).HasColumnName("Id");

            builder.HasKey(entity => entity.Id);

            builder.ToTable(nameof(Gender), "dbo");

            builder.HasMany(p => p.CustomerList).WithOne(b => b.Gender).HasForeignKey(p => p.GenderId);
        }
    }
}
