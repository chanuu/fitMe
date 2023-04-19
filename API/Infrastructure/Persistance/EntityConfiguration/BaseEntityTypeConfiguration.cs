using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.EntityConfiguration
{
    public class BaseEntityTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
         where TEntity : Entity
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
