using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthwindDbBase.Entitees;

namespace NorthwindDbBase.EntiteesConfiguration
{
    public class RegionConfiguration : IEntityTypeConfiguration<Regions>
    {
        public void Configure(EntityTypeBuilder<Regions> builder)
        {
            builder.HasKey(p => p.RegionID).HasAnnotation("SqlServer:Clustered", false);
 
            builder.Property(p => p.RegionDescription).IsRequired(false).HasMaxLength(50);
        }
    }
}
