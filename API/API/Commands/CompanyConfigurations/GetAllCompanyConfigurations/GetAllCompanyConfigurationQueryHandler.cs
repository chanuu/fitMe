using API.Commands.Users.GetAllUsers;
using Application.Abstraction.Domain.Companies;
using Application.Abstraction.Domain.Users;
using AutoMapper;
using MediatR;

namespace API.Commands.CompanyConfigurations.GetAllCompanyConfigurations
{
    
    public class GetAllCompanyConfigurationQueryHandler : IRequestHandler<GetAllCompanyConfigurationQuery, List<Domain.Aggregates.Companies.CompanyConfiguration>>
    {
        private readonly ICompanyConfigurationRepository _companyConfigurationRepository;


        public GetAllCompanyConfigurationQueryHandler(ICompanyConfigurationRepository companyConfigurationRepository, IMapper mapper)
        {
            _companyConfigurationRepository = companyConfigurationRepository;

        }

        public async Task<List<Domain.Aggregates.Companies.CompanyConfiguration>> Handle(GetAllCompanyConfigurationQuery request, CancellationToken cancellationToken)
        {
            var companyConfig= await _companyConfigurationRepository.GetAllAsync();
            return companyConfig;
        }



    }
}
