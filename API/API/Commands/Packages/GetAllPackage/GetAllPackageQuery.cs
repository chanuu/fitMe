using MediatR;

namespace API.Commands.Packages.GetAllPackage
{
    public class GetAllPackageQuery : IRequest<List<Domain.Aggregates.Companies.Package>>
    {
    }
}
