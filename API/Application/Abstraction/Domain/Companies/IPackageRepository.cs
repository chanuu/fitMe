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
    public interface IPackageRepository : IRepository<Package>, ITransientService
    {
        Package Add(Package package);
        
        Task<List<Package>> GetAllAsync();

        void Update(Package package);
        Task<Package> GetAsync(Guid Id);

        void Remove(Package package);
    }
}
