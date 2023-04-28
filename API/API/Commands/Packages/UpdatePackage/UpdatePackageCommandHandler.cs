using API.Commands.Users.UpdateUser;
using Application.Abstraction.Domain.Companies;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;

namespace API.Commands.Packages.UpdatePackage
{
    public class UpdatePackageCommandHandler : IRequestHandler<UpdatePackageCommand, Domain.Aggregates.Companies.Package>
    {
        private readonly IPackageRepository _packageRepository;

        public UpdatePackageCommandHandler(IPackageRepository packageRepository)
        {
            _packageRepository = packageRepository;
        }

        public async Task<Domain.Aggregates.Companies.Package> Handle(UpdatePackageCommand request, CancellationToken cancellationToken)
        {
            var package = await _packageRepository.GetAsync(request.Id);
            if (package == null)
            {
                return null;
            }

            package.CompanyId = request.CompanyId;
            package.Name = request.Name;
            package.Description = request.Description;
            package.IsActive = request.IsActive;
            package.Price = request.Price;
            

            _packageRepository.Update(package);
            await _packageRepository.UnitOfWork.SaveChangesAsync(cancellationToken);

            return package;
        }


    }
}
