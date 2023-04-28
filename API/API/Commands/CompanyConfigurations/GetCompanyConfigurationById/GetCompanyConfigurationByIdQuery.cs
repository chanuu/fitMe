using MediatR;

namespace API.Commands.CompanyConfigurations.GetCompanyConfigurationById
{
    
        public class GetCompanyConfigurationByIdQuery : IRequest<Domain.Aggregates.Companies.CompanyConfiguration>
        {
            public Guid id { get; set; }
        }
    
}
