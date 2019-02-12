using Management.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Management.Infrastructure.Repositories.Relational.Mappers
{
    public class ClassificationMap : IEntityTypeConfiguration<Classification>
    {
        public void Configure(EntityTypeBuilder<Classification> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.Property(entity => entity.Id).HasColumnName("Id");

            builder.HasKey(entity => entity.Id);

            builder.ToTable(nameof(Classification), "dbo");
        }
    }
}
