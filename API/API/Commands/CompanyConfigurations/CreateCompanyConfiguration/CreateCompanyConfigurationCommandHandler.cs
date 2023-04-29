using Application.Abstraction.Domain.Companies;
using MediatR;

namespace API.Commands.CompanyConfigurations.CreateCompanyConfiguration
{
    public class CreateCompanyConfigurationCommandHandler : IRequestHandler<CreateCompanyConfigurationCommand, Domain.Aggregates.Companies.CompanyConfiguration>
    {

        private readonly ICompanyConfigurationRepository _companyConfigurationRepository;

        public CreateCompanyConfigurationCommandHandler(ICompanyConfigurationRepository companyConfigurationRepository)
        {
            _companyConfigurationRepository = companyConfigurationRepository;
        }

        public async Task<Domain.Aggregates.Companies.CompanyConfiguration> Handle(CreateCompanyConfigurationCommand request, CancellationToken cancellationToken)
        {
            Domain.Aggregates.Companies.CompanyConfiguration companyConfiguration = new
            Domain.Aggregates.Companies.CompanyConfiguration(request.OpenTime, request.CloseTime, request.MaximumCapacity, request.TimeSlotLength);
            _companyConfigurationRepository.Add(companyConfiguration);
            await _companyConfigurationRepository.UnitOfWork.SaveChangesAsync();
            return companyConfiguration;
        }
    }
}
