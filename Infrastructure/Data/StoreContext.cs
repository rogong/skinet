using System;
using System.Linq;
using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }

        public DbSet<Product> Products {get; set; }
        public DbSet<ProductBrand> ProductBrands {get; set; }
        public DbSet<ProductType> ProductTypes {get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

             if(Database.ProviderName == "Microsoft.EntityFrameworkCore.Sqlite")
            {
                foreach(var item in modelBuilder.Model.GetEntityTypes())
                {
                    var props = item.ClrType.GetProperties().Where(p => p.PropertyType == typeof(decimal));
                    var dateTimeProperties = item.ClrType.GetProperties().Where(p => p.PropertyType == typeof(DateTimeOffset));
                    foreach(var prop in props)
                    {
                        modelBuilder.Entity(item.Name).Property(prop.Name).HasConversion<double>();
                    }
                    foreach (var prop in dateTimeProperties)
                    {
                        modelBuilder.Entity(item.Name).Property(prop.Name).HasConversion(new DateTimeOffsetToBinaryConverter());
                    }
                }
            }
        }
    }
}