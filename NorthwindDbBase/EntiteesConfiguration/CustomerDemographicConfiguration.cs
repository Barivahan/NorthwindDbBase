using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthwindDbBase.Entitees;


namespace NorthwindDbBase.EntiteesConfiguration
{
    class CustomerDemographicConfiguration : IEntityTypeConfiguration<CustomerDemographics>
    {
        public void Configure(EntityTypeBuilder<CustomerDemographics> builder)
        {
            builder.HasKey(p => p.CustomerTypeID).HasAnnotation("SqlServer:Clustered", false);
            builder.Property(p => p.CustomerTypeID).HasMaxLength(5).IsRequired();
        }
    }
}
