using Microsoft.EntityFrameworkCore;
using NorthwindDbBase.Entitees;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NorthwindDbBase.EntiteesConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasKey(p => p.ProductID);
            builder.HasIndex(p => p.ProductName);

            builder.Property(p => p.ProductName).HasMaxLength(40).IsRequired(true);
            builder.Property(p => p.SupplierID).IsRequired(false);
            builder.Property(p => p.CategoryID).IsRequired(false);
            builder.Property(p => p.QuantityPerUnit).IsRequired(false).HasMaxLength(20);
            builder.Property(p => p.UnitPrice).IsRequired(false).HasColumnType("MONEY").HasDefaultValue(new decimal());
            builder.Property(p => p.UnitsInStock).IsRequired(false).HasDefaultValue(new short());
            builder.Property(p => p.UnitsOnOrder).IsRequired(false).HasDefaultValue(new short());
            builder.Property(p => p.ReorderLevel).IsRequired(false).HasDefaultValue(new short());
            builder.Property(p => p.Discontinued).IsRequired(true);
            builder.HasCheckConstraint("CK_Products_UnitPrice", "UnitPrice >= 0");
            builder.HasCheckConstraint("CK_ReorderLevel", "ReorderLevel >= 0");
            builder.HasCheckConstraint("CK_UnitsInStock", "UnitsInStock >= 0");
            builder.HasCheckConstraint("CK_UnitsOnOrder", "UnitsOnOrder >= 0");

            builder.HasOne<Categories>()
            .WithMany()
            .HasForeignKey(p => p.CategoryID)
            .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Suppliers>()
                .WithMany()
                .HasForeignKey(p => p.SupplierID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
