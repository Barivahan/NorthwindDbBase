using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthwindDbBase.Entitees;

namespace NorthwindDbBase.EntiteesConfiguration
{
    class EmployeeTerritorieConfiguration : IEntityTypeConfiguration<EmployeeTerritories>
    {
        public void Configure(EntityTypeBuilder<EmployeeTerritories> builder)
        {
            builder.HasKey(p => new { p.EmployeeID, p.TerritoryID }).HasAnnotation("SqlServer:Clustered", false);
            builder.Property(p => p.TerritoryID).HasMaxLength(20);

            builder.HasOne<Employees>()
                .WithMany()
                .HasForeignKey(p => p.EmployeeID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Territories>()
                .WithMany()
                .HasForeignKey(p => p.TerritoryID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
