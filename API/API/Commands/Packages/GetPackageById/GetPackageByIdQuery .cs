using MediatR;

namespace API.Commands.Packages.GetPackageById
{
    public class GetPackageByIdQuery : IRequest<Domain.Aggregates.Companies.Package>
    {
        public Guid Id { get; set; }
    }
}
