using Application.Abstraction.Domain.Companies;
using Application.Commands.Company.CreateCompanies;
using Domain.Aggregates.Companies;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Companies.CreateCompany
{
    public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand, Domain.Aggregates.Companies.Company>
    {
        private readonly ICompanyRepository _CompanyRepository;

        public CreateCompanyCommandHandler(ICompanyRepository companyRepository)
        {
            _CompanyRepository = companyRepository;
        }

        public Task<Domain.Aggregates.Companies.Company> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
