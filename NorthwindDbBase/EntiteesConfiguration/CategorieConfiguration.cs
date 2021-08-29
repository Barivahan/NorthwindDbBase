using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthwindDbBase.Entitees;
using System;

namespace NorthwindDbBase.EntiteesConfiguration
{
    public class CategorieConfiguration : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.HasKey(p => p.CategoryID);
            builder.Property(p => p.CategoryName).IsRequired().HasMaxLength(15);
            builder.Property(p => p.Description).HasColumnType("NTEXT");
            builder.Property(p => p.Picture).HasColumnType("IMAGE");
            builder.HasIndex(p => p.CategoryName);
        }
    }
}
