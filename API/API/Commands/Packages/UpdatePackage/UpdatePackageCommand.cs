using MediatR;

namespace API.Commands.Packages.UpdatePackage
{
    public class UpdatePackageCommand : IRequest<Domain.Aggregates.Companies.Package>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; } = true;

        public double Price { get; set; }

        public Guid CompanyId { get; set; }


        
    }
}
