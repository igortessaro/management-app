using Management.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Management.Infrastructure.Repositories.Relational.Mappers
{
    public class UserRoleMap : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.Property(entity => entity.Id).HasColumnName("Id");

            builder.HasKey(entity => entity.Id);

            builder.ToTable(nameof(UserRole), "dbo");

            builder.HasMany(p => p.UserSysList).WithOne(b => b.UserRole).HasForeignKey(p => p.UserRoleId);
        }
    }
}
