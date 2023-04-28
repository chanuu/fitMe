using API.Commands.Packages.CreatePackage;
using API.Commands.Users.GetAllUsers;
using Application.Abstraction.Domain.Companies;
using MediatR;

namespace API.Commands.Packages.GetAllPackage
{

    public class GetAllPackageQueryHandler : IRequestHandler<GetAllPackageQuery,List< Domain.Aggregates.Companies.Package>>
    {
        private readonly IPackageRepository _packageRepository;

        public GetAllPackageQueryHandler(IPackageRepository packageRepository)
        {
            _packageRepository = packageRepository;
        }

        public async Task<List<Domain.Aggregates.Companies.Package>> Handle(GetAllPackageQuery request, CancellationToken cancellationToken)
        {
            var package = await _packageRepository.GetAllAsync();
            return package;
        }
    }
}