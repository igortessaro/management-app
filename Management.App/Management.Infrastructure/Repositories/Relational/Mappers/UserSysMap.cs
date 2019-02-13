using Management.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Management.Infrastructure.Repositories.Relational.Mappers
{
    public class UserSysMap : IEntityTypeConfiguration<UserSys>
    {
        public void Configure(EntityTypeBuilder<UserSys> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.Property(entity => entity.Id).HasColumnName("Id");

            builder.HasKey(entity => entity.Id);

            builder.ToTable(nameof(UserSys), "dbo");

            builder.HasOne(p => p.UserRole).WithMany(b => b.UserSysList).HasForeignKey(p => p.UserRoleId);

            builder.HasMany(p => p.CustomerList).WithOne(b => b.User).HasForeignKey(p => p.UserId);
        }
    }
}
