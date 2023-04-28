using API.Commands.CompanyConfigurations.UpdateCompanyConfiguration;
using API.Commands.Users.DeleteUser;
using Application.Abstraction.Domain.Companies;
using MediatR;

namespace API.Commands.CompanyConfigurations.DeleteCompanyConfiguration
{

    public class DeleteCompanyConfigurationCommandHandler : IRequestHandler<DeleteCompanyConfigurationCommand, Domain.Aggregates.Companies.CompanyConfiguration>
    {
        private readonly ICompanyConfigurationRepository _companyConfigurationRepository;

        public DeleteCompanyConfigurationCommandHandler(ICompanyConfigurationRepository companyConfigurationRepository)
        {
            _companyConfigurationRepository = companyConfigurationRepository;
        }

        public async Task<Domain.Aggregates.Companies.CompanyConfiguration> Handle(DeleteCompanyConfigurationCommand request, CancellationToken cancellationToken)
        {
            var companyConfig= await _companyConfigurationRepository.GetAsync(request.Id);
            if (companyConfig == null)
            {
                return null;
            }

            _companyConfigurationRepository.Remove(companyConfig);
            await _companyConfigurationRepository.UnitOfWork.SaveChangesAsync(cancellationToken);

            return companyConfig;
        }
    }
}
