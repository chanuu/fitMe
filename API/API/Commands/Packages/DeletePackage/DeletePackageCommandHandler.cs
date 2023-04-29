using API.Commands.Packages.GetAllPackage;
using API.Commands.Users.DeleteUser;
using Application.Abstraction.Domain.Companies;
using MediatR;

namespace API.Commands.Packages.DeletePackage
{

    public class DeletePackageCommandHandler : IRequestHandler<DeletePackageCommand, Domain.Aggregates.Companies.Package>
    {
        private readonly IPackageRepository _packageRepository;

        public DeletePackageCommandHandler(IPackageRepository packageRepository)
        {
            _packageRepository = packageRepository;
        }
        public async Task<Domain.Aggregates.Companies.Package> Handle(DeletePackageCommand request, CancellationToken cancellationToken)
        {
            var package = await _packageRepository.GetAsync(request.Id);
            if (package == null)
            {
                return null;
            }

            _packageRepository.Remove(package);
            await _packageRepository.UnitOfWork.SaveChangesAsync(cancellationToken);

            return package;
        }
    }
}
