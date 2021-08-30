using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthwindDbBase.Entitees;

namespace NorthwindDbBase.EntiteesConfiguration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder.HasKey(p => p.CustomerID);

            builder.HasIndex(p => p.CompanyName);
            builder.HasIndex(p => p.City);
            builder.HasIndex(p => p.PostalCode);
            builder.HasIndex(p => p.Region);

            builder.Property(p => p.CustomerID).HasMaxLength(5).IsRequired(true);
            builder.Property(p => p.CompanyName).HasMaxLength(40).IsRequired(true);
            builder.Property(p => p.ContactName).HasMaxLength(30);
            builder.Property(p => p.ContactTitle).HasMaxLength(30);
            builder.Property(p => p.Address).HasMaxLength(60);
            builder.Property(p => p.City).HasMaxLength(15);
            builder.Property(p => p.Region).HasMaxLength(15);
            builder.Property(p => p.PostalCode).HasMaxLength(10);
            builder.Property(p => p.Country).HasMaxLength(15);
            builder.Property(p => p.Phone).HasMaxLength(24);
            builder.Property(p => p.Fax).HasMaxLength(24);
        }
    }
}
