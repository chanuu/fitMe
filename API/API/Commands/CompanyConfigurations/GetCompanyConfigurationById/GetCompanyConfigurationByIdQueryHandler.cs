using API.Commands.CompanyConfigurations.UpdateCompanyConfiguration;
using API.Commands.Users.GetUserById;
using Application.Abstraction.Domain.Companies;
using MediatR;

namespace API.Commands.CompanyConfigurations.GetCompanyConfigurationById
{
        public class GetCompanyConfigurationByIdQueryHandler : IRequestHandler<GetCompanyConfigurationByIdQuery, Domain.Aggregates.Companies.CompanyConfiguration>
        {
            private readonly ICompanyConfigurationRepository _companyConfigurationRepository;

            public GetCompanyConfigurationByIdQueryHandler(ICompanyConfigurationRepository companyConfigurationRepository)
            {
                _companyConfigurationRepository = companyConfigurationRepository;
            }

            public async Task<Domain.Aggregates.Companies.CompanyConfiguration> Handle(GetCompanyConfigurationByIdQuery request, CancellationToken cancellationToken)
            {
                var companyConfig = await _companyConfigurationRepository.GetAsync(request.id);

                return companyConfig;
            }


    }
}
