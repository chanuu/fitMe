using Application.Abstraction.Platfrom.Common;
using Domain.Aggregates.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction.Domain.Companies
{
    public interface ICompanyRepository : IRepository<Company>, ITransientService
    {
        Company Add(Company company);

        void Update(Company company);

        Task<Company> ConfirmAsync(Guid companyId);

        Task<Company> GetAsync(Guid companyId);

        Task<List<Company>> GetAllAsync();

     
        void Remove(Company company);
    }
}
