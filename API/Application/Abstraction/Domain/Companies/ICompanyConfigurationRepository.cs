using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Abstraction.Platfrom.Common;
using Domain.Aggregates.Companies;
using Domain.Aggregates.User;

namespace Application.Abstraction.Domain.Companies
{
    
    public interface ICompanyConfigurationRepository : IRepository<CompanyConfiguration>, ITransientService
    {
        CompanyConfiguration Add(CompanyConfiguration companyConfiguration);     
        Task<List<CompanyConfiguration>> GetAllAsync();
        void Update(CompanyConfiguration companyConfiguration);
        Task<CompanyConfiguration> GetAsync(Guid Id);
        void Remove(CompanyConfiguration companyConfiguration);



    }
}
