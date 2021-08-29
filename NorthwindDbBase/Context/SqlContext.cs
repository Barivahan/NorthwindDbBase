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
            optionsBuilder.UseSqlServer("Server=DESKTOP-UN8K0C5\\SQLEXPRESS;Database=NorthwindFluentApi;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Categories>(new CategorieConfiguration());
            modelBuilder.ApplyConfiguration<Products>(new ProductConfiguration());
            modelBuilder.ApplyConfiguration<Suppliers>(new SupplierConfiguration());
        }
    }
}
