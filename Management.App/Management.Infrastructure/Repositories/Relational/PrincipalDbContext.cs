using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Management.Infrastructure.Repositories.Relational
{
    public class PrincipalDbContext : DbContext
    {
        public PrincipalDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration();

            base.OnModelCreating(modelBuilder);
        }
    }
}
