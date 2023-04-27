using Application.Abstraction.Domain.Companies;
using Application.Abstraction.Platfrom;
using Domain.Aggregates.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
         private readonly ApiContext _context;

        public IUnitofWork UnitOfWork
        {
            get { return _context; }
        }

        public CompanyRepository(ApiContext context)
        {
            _context = context;
        }

        public Company Add(Company company)
        {
           _context.Add(company);
            return company;
        }

        public Task<Company> ConfirmAsync(Guid companyId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Company>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Company>> GetAllAsyncByCustomer(Guid companyId)
        {
            throw new NotImplementedException();
        }

        public Task<Company> GetAsync(Guid companyId)
        {
            throw new NotImplementedException();
        }

        public void RemoveOrderItem(List<Company> items)
        {
            throw new NotImplementedException();
        }

        public Task<Company> Update(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
