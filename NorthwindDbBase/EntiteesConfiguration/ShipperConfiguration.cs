using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthwindDbBase.Entitees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDbBase.EntiteesConfiguration
{
    class ShipperConfiguration : IEntityTypeConfiguration<Shippers>
    {
        public void Configure(EntityTypeBuilder<Shippers> builder)
        {
            builder.HasKey(p => p.ShipperID);
            builder.Property(p => p.CompanyName).HasMaxLength(40).IsRequired();
            builder.Property(p => p.Phone).HasMaxLength(24);
        }
    }
}
