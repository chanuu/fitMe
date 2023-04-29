using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Abstraction.Domain.Companies;
using Application.Abstraction.Domain.Users;
using Application.Abstraction.Platfrom;
using Domain.Aggregates.Companies;
using Domain.Aggregates.User;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistance.Repositories
{
    
    public class PackageRepository : IPackageRepository
    {
        private readonly ApiContext _context;

        public IUnitofWork UnitOfWork
        {
            get { return _context; }
        }

        public PackageRepository(ApiContext context)
        {
            _context = context;
        }

        public Package Add(Package package)
        {
            _context.Add(package);
            return package;
        }

      
        public async Task<List<Package>> GetAllAsync()
        {
            return await _context.Package.ToListAsync();

        }

        public async Task<Package> GetAsync(Guid Id)
        {
            return await _context.Package.FirstOrDefaultAsync(o => o.Id == Id);

        }

        public void Remove(Package package)
        {
            _context.Package.Remove(package);
        }

        public void Update(Package package)
        {
            _context.Package.Update(package);
        }

    }
}
