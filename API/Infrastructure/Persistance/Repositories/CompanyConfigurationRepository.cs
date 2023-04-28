using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Abstraction.Domain.Companies;
using Application.Abstraction.Platfrom;
using Domain.Aggregates.Companies;
using Domain.Aggregates.User;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistance.Repositories
{
   
    public class CompanyConfigurationRepository : ICompanyConfigurationRepository
    {
        private readonly ApiContext _context;

        public IUnitofWork UnitOfWork
        {
            get { return _context; }
        }

        public CompanyConfigurationRepository(ApiContext context)
        {
            _context = context;
        }

        public CompanyConfiguration Add(CompanyConfiguration companyConfiguration)
        {
            _context.Add(companyConfiguration);
            return companyConfiguration;
        }

        
        public async Task<List<CompanyConfiguration>> GetAllAsync()
        {
            return await _context.CompanyConfiguration.ToListAsync();

        }

          

        public void Update(CompanyConfiguration companyConfiguration)
        {
            _context.CompanyConfiguration.Update(companyConfiguration);
        }

        public async Task<CompanyConfiguration> GetAsync(Guid Id)
        {
            return await _context.CompanyConfiguration.FirstOrDefaultAsync(o => o.Id == Id);
        }

        public void Remove(CompanyConfiguration companyConfiguration)
        {
            _context.CompanyConfiguration.Remove(companyConfiguration);
        }

    }
}
