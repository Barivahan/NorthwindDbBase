using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthwindDbBase.Entitees;

namespace NorthwindDbBase.EntiteesConfiguration
{
    class EmployeeConfiguration : IEntityTypeConfiguration<Employees>
    {
        public void Configure(EntityTypeBuilder<Employees> builder)
        {
            builder.HasKey(p => p.EmployeeID);

            builder.Property(p => p.LastName).IsRequired().HasMaxLength(20);
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(10);
            builder.Property(p => p.Title).HasMaxLength(30);
            builder.Property(p => p.TitleOfCourtesy).HasMaxLength(25);
            builder.Property(p => p.BirthDate).IsRequired(false);
            builder.Property(p => p.HireDate).IsRequired(false);

            builder.Property(p => p.Address).HasMaxLength(60);
            builder.Property(p => p.City).HasMaxLength(15);
            builder.Property(p => p.Region).HasMaxLength(15);
            builder.Property(p => p.PostalCode).HasMaxLength(10);
            builder.Property(p => p.Country).HasMaxLength(15);
            builder.Property(p => p.HomePhone).HasMaxLength(24);
            builder.Property(p => p.Extension).HasMaxLength(4);

            builder.Property(p => p.Photo).HasColumnType("IMAGE");
            builder.Property(p => p.PhotoPath).HasMaxLength(255);

            builder.HasCheckConstraint("CK_BirthDate", "BirthDate < GetDate()");

            builder.HasOne<Employees>()
                .WithMany()
                .HasForeignKey(p => p.ReportsTo)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
