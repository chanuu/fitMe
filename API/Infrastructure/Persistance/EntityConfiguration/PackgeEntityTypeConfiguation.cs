using Domain.Aggregates.Companies;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.EntityConfiguration
{
    public class PackageEntityTypeConfiguation : BaseEntityTypeConfiguration<Package>
    {
        public override void Configure(EntityTypeBuilder<Package> builder)
        {
            base.Configure(builder);

            base.Configure(builder);

            builder.Property<Guid>("PackageId").IsRequired();

            builder.Property<Double>("Price").IsRequired();
        }
    }
}
