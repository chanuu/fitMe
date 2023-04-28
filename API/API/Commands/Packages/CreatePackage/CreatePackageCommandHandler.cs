using API.Commands.Users.CreateUser;
using Application.Abstraction.Domain.Companies;
using Application.Abstraction.Domain.Users;
using MediatR;

namespace API.Commands.Packages.CreatePackage
{

    public class CreatePackageCommandHandler : IRequestHandler<CreatePackageCommand, Domain.Aggregates.Companies.Package>
    {
        private readonly IPackageRepository _packageRepository;

        public CreatePackageCommandHandler(IPackageRepository packageRepository)
        {
            _packageRepository = packageRepository;
        }

        public async Task<Domain.Aggregates.Companies.Package> Handle(CreatePackageCommand request, CancellationToken cancellationToken)
        {
            Domain.Aggregates.Companies.Package package = new
            Domain.Aggregates.Companies.Package(request.Name, request.Description, request.IsActive, request.Price, request.CompanyId);
            _packageRepository.Add(package);
            await _packageRepository.UnitOfWork.SaveChangesAsync();
            return package;
        }
    }
}

