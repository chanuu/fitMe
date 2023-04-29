using MediatR;

namespace API.Commands.CompanyConfigurations.GetAllCompanyConfigurations
{
    public class GetAllCompanyConfigurationQuery : IRequest<List<Domain.Aggregates.Companies.CompanyConfiguration>>
    {
    }
}
