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

            builder.HasKey(p => new {p.OrderID, p.ProductID });
            builder.HasOne<Orders>()
                .WithMany()
                .HasForeignKey(p => p.OrderID);

            builder.HasOne<Products>()
                .WithMany()
                .HasForeignKey(p => p.ProductID);



        }
    }
}
