using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthwindDbBase.Entitees;

namespace NorthwindDbBase.EntiteesConfiguration
{
    class CustomerCustomerDemoConfiguration : IEntityTypeConfiguration<CustomerCustomerDemo>
    {
        public void Configure(EntityTypeBuilder<CustomerCustomerDemo> builder)
        {
            builder.HasKey(p => new { p.CustomerID, p.CustomerTypeID });

            builder.Property(p => p.CustomerID).IsRequired().HasMaxLength(5);
            builder.Property(p => p.CustomerTypeID).IsRequired().HasMaxLength(5);

            builder.HasOne<Customers>()
                .WithMany()
                .HasForeignKey(p => p.CustomerID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<CustomerDemographics>()
                .WithMany()
                .HasForeignKey(p => p.CustomerTypeID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
