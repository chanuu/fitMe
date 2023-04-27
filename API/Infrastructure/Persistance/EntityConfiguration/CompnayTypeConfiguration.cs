using Domain.Aggregates.Companies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.EntityConfiguration
{
    public class CompnayTypeConfiguration : BaseEntityTypeConfiguration<Company>
    {
        public override void Configure(EntityTypeBuilder<Company> builder)
        {
            base.Configure(builder);

            var navigation = builder.Metadata.FindNavigation(nameof(Company.Packages));
            navigation.SetPropertyAccessMode(PropertyAccessMode.Field);



        }
    }
}
