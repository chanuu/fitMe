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

        Task<Company> Update(Company company);

        Task<Company> ConfirmAsync(Guid companyId);

        Task<Company> GetAsync(Guid companyId);

        Task<List<Company>> GetAllAsync();

        Task<List<Company>> GetAllAsyncByCustomer(Guid companyId);

        void RemoveOrderItem(List<Company> items);
    }
}
