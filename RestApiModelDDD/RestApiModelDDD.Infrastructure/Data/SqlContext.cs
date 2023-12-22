using Microsoft.EntityFrameworkCore;
using RestApiModelDDD.Domain.Entities;
using System;
using System.Linq;

namespace RestApiModelDDD.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }

        public SqlContext()
        { }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("RegistrationDate") != null))
            {
                if (entry.State == EntityState.Added)
                    entry.Property("RegistrationDate").CurrentValue = DateTime.Now;
                if (entry.State == EntityState.Modified)
                    entry.Property("RegistrationDate").IsModified = false;
            }

            return base.SaveChanges();
        }
    }
}