using API.Commands.Packages.GetAllPackage;
using API.Commands.Users.GetUserById;
using Application.Abstraction.Domain.Companies;
using MediatR;

namespace API.Commands.Packages.GetPackageById
{
    public class GetPackageByIdQueryHandler : IRequestHandler<GetPackageByIdQuery, Domain.Aggregates.Companies.Package>
    {
        private readonly IPackageRepository _packageRepository;

        public GetPackageByIdQueryHandler(IPackageRepository packageRepository)
        {
            _packageRepository = packageRepository;
        }

        public async Task<Domain.Aggregates.Companies.Package> Handle(GetPackageByIdQuery request, CancellationToken cancellationToken)
        {
            var package = await _packageRepository.GetAsync(request.Id);

            return package;
        }
    }
}
