using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthwindDbBase.Entitees;
using System.ComponentModel.DataAnnotations.Schema;
using NorthwindDbBase.EntiteesConfiguration;

namespace NorthwindDbBase.EntiteesConfiguration
{
    public class Order_DetailConfiguration : IEntityTypeConfiguration<Order_Details>
    {
        public void Configure(EntityTypeBuilder<Order_Details> builder)
        {
            builder.HasKey(p => new { p.OrderID, p.ProductID });
            builder.HasIndex(p => p.OrderID);
            builder.HasIndex(p => p.ProductID);

            builder.HasOne<Orders>()
                .WithMany()
                .HasForeignKey(p => p.OrderID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Products>()
                .WithMany()
                .HasForeignKey(p => p.ProductID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(p => p.UnitPrice).HasColumnType("MONEY").HasDefaultValue(0);
            builder.Property(p => p.Quantity).HasColumnType("SMALLINT").HasDefaultValue(1);
            builder.Property(p => p.Discount).HasColumnType("Real").HasDefaultValue(0);

            builder.HasCheckConstraint("CK_Discount", " Discount >= 0 and Discount <= 1");
            builder.HasCheckConstraint("CK_Quantity", "Quantity >= 0");
            builder.HasCheckConstraint("CK_UnitPrice", "UnitPrice >= 0");
        }
    }
}
