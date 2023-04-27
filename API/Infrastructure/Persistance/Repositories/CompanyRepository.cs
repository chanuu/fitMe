using Application.Abstraction.Domain.Companies;
using Application.Abstraction.Platfrom;
using Domain.Aggregates.Companies;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Company>> GetAllAsync()
        {
            return await _context.Company.ToListAsync();
        }

        
        public async Task<Company> GetAsync(Guid companyId)
        {
            return await _context.Company.FirstOrDefaultAsync(o => o.Id == companyId);
        }

        public void Remove(Company company)
        {
            _context.Company.Remove(company);
        }

        public  void Update(Company company)
        {
            _context.Company.Update(company);
        }
    }
}
