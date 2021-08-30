using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthwindDbBase.Entitees;

namespace NorthwindDbBase.EntiteesConfiguration
{
   public class TerritorieConfiguration : IEntityTypeConfiguration<Territories>
    {
        public void Configure(EntityTypeBuilder<Territories> builder)
        {
            builder.HasKey(p => p.TerritoryID).HasAnnotation("SqlServer:Clustered", false);

            builder.Property(p => p.TerritoryID).HasMaxLength(20).IsRequired();
            builder.Property(p => p.TerritoryDescription).HasMaxLength(50).IsRequired();
            builder.Property(p => p.RegionID).IsRequired(false);

            builder.HasOne<Regions>()
                .WithMany()
                .HasForeignKey(p => p.RegionID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
