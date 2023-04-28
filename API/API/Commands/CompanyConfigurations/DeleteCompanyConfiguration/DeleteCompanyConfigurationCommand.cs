using MediatR;

namespace API.Commands.CompanyConfigurations.DeleteCompanyConfiguration
{
    public class DeleteCompanyConfigurationCommand : IRequest<Domain.Aggregates.Companies.CompanyConfiguration>
    {
    
        public Guid Id { get; set; }
    }
}
