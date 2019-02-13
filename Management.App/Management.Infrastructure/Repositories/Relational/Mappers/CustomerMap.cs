using Management.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Management.Infrastructure.Repositories.Relational.Mappers
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.Property(entity => entity.Id).HasColumnName("Id");

            builder.HasKey(entity => entity.Id);

            builder.ToTable(nameof(Customer), "dbo");

            builder.HasOne(p => p.User).WithMany(b => b.CustomerList).HasForeignKey(p => p.UserId);
            builder.HasOne(p => p.Classification).WithMany(b => b.CustomerList).HasForeignKey(p => p.ClassificationId);
            builder.HasOne(p => p.City).WithMany(b => b.CustomerList).HasForeignKey(p => p.CityId);
            builder.HasOne(p => p.Gender).WithMany(b => b.CustomerList).HasForeignKey(p => p.GenderId);
            builder.HasOne(p => p.Region).WithMany(b => b.CustomerList).HasForeignKey(p => p.RegionId);
        }
    }
}
