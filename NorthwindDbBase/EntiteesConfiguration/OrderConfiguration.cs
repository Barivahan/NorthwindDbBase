using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthwindDbBase.Entitees;

namespace NorthwindDbBase.EntiteesConfiguration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Orders>
    {
        public void Configure(EntityTypeBuilder<Orders> builder)
        {
            builder.HasKey(p => p.OrderID);

            builder.Property(p => p.CustomerID).HasMaxLength(5).IsRequired(false);
            builder.Property(p => p.OrderDate).IsRequired(false);
            builder.Property(p => p.RequiredDate).IsRequired(false);
            builder.Property(p => p.ShippedDate).IsRequired(false);
            builder.Property(p => p.ShipVia).IsRequired(false);
            builder.Property(p => p.Freight).IsRequired(false).HasColumnType("MONEY").HasDefaultValue(new decimal());
            builder.Property(p => p.ShipName).HasMaxLength(40);
            builder.Property(p => p.ShipAddress).HasMaxLength(60);
            builder.Property(p => p.ShipCity).HasMaxLength(15);
            builder.Property(p => p.ShipRegion).HasMaxLength(15);
            builder.Property(p => p.ShipPostalCode).HasMaxLength(10);
            builder.Property(p => p.ShipCountry).HasMaxLength(15);

            builder.HasOne<Shippers>()
            .WithMany()
            .HasForeignKey(p => p.ShipVia)
            .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Customers>()
            .WithMany()
            .HasForeignKey(p => p.CustomerID)
            .OnDelete(DeleteBehavior.NoAction);

            //  To do 

            //builder.HasOne<Employees>()
            //.WithMany()
            //.HasForeignKey(p => p.EmployeeID)
            //.OnDelete(DeleteBehavior.NoAction);

        }
    }
}
