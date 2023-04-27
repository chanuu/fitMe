using Application.Abstraction.Platfrom;
using Domain.Aggregates.Companies;
using Infrastructure.Persistance.EntityConfiguration;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance
{
    public class ApiContext : DbContext, IUnitofWork
    {
        private readonly IMediator _mediator;

        public DbSet<Company> Company {get;set;}

        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

        public ApiContext(DbContextOptions<ApiContext> options, IMediator mediator) : base(options)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BaseEntityTypeConfiguration<>).Assembly);
        }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            await _mediator.DispatchDomainEventsAsync(this);

            var result = await base.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
