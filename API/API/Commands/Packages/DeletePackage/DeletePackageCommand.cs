using MediatR;

namespace API.Commands.Packages.DeletePackage
{
    public class DeletePackageCommand : IRequest<Domain.Aggregates.Companies.Package>
    {
        public Guid Id { get; set; }
    }
    
}
