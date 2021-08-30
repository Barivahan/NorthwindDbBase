using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDbBase.Entitees;
using NorthwindDbBase.EntiteesConfiguration;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace NorthwindDbBase.Context
{
    public class SqlContext : DbContext
    {
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }

        //public SqlContext()
        //{
        //    Database.EnsureCreatedAsync();
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectsV13;Database=NorthwindFluentApi;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Categories>(new CategorieConfiguration());
            modelBuilder.ApplyConfiguration<Products>(new ProductConfiguration());
            modelBuilder.ApplyConfiguration<Suppliers>(new SupplierConfiguration());
            modelBuilder.ApplyConfiguration<Order_Details>(new Order_DetailConfiguration());
            modelBuilder.ApplyConfiguration<Orders>(new OrderConfiguration());
            modelBuilder.ApplyConfiguration<Shippers>(new ShipperConfiguration());
            modelBuilder.ApplyConfiguration<Customers>(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration<CustomerCustomerDemo>(new CustomerCustomerDemoConfiguration());
            modelBuilder.ApplyConfiguration<CustomerDemographics>(new CustomerDemographicConfiguration());
        }
    }
}
