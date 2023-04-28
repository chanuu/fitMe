using Application.Abstraction.Domain.Companies;
using MediatR;

namespace API.Commands.CompanyConfigurations.UpdateCompanyConfiguration
{  
    public class UpdateCompanyConfigurationCommandHandler : IRequestHandler<UpdateCompanyConfigurationCommand, Domain.Aggregates.Companies.CompanyConfiguration>
    {
        private readonly ICompanyConfigurationRepository _companyConfigurationRepository;

        public UpdateCompanyConfigurationCommandHandler(ICompanyConfigurationRepository companyConfigurationRepository)
        {
            _companyConfigurationRepository = companyConfigurationRepository;
        }

        public async Task<Domain.Aggregates.Companies.CompanyConfiguration> Handle(UpdateCompanyConfigurationCommand request, CancellationToken cancellationToken)
        {
            Domain.Aggregates.Companies.CompanyConfiguration companyConfiguration = await _companyConfigurationRepository.GetAsync(request.Id);
            if (companyConfiguration == null)
            {
                return null;
                
            }

            
            companyConfiguration.OpenTime = request.OpenTime;
            companyConfiguration.CloseTime = request.CloseTime;
            companyConfiguration.TimeSlotLength = request.TimeSlotLength;
            companyConfiguration.MaximumCapacity = request.MaximumCapacity;

            _companyConfigurationRepository.Update(companyConfiguration);
            await _companyConfigurationRepository.UnitOfWork.SaveChangesAsync();

            return companyConfiguration;
        }
    }
}
