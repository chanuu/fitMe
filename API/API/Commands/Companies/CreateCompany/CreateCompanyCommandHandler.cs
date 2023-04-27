using API.Commands.Company.CreateCompanies;
using Application.Abstraction.Domain.Companies;
using Domain.Aggregates.Companies;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Commands.Companies.CreateCompany
{
    public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand, Domain.Aggregates.Companies.Company>
    {
        private readonly ICompanyRepository _CompanyRepository;

        public CreateCompanyCommandHandler(ICompanyRepository companyRepository)
        {
            _CompanyRepository = companyRepository;
        }

        public async Task<Domain.Aggregates.Companies.Company> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            Domain.Aggregates.Companies.Company company = new
            Domain.Aggregates.Companies.Company(request.Name,request.Address,request.TeleNo,request.EmailAddress);
             _CompanyRepository.Add(company);
            await _CompanyRepository.UnitOfWork.SaveChangesAsync();
            return company;
        }
    }
}
